using UnityEngine;
using UnityEngine.EventSystems;

public class PinchToZoomAndPan : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool _isDragging;
    private float _currentScale;
    private Vector2 _initialTouchPos;
    private Vector2 _initialScale;

    public float minScale, maxScale;
    private float _scalingRate = 0.5f;

    private void Start()
    {
        _currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (Input.touchCount == 2)
        {
            _isDragging = true;
            _initialTouchPos = (Input.GetTouch(0).position + Input.GetTouch(1).position) / 2.0f;
            _initialScale = transform.localScale;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _isDragging = false;
    }

    private void Update()
    {
        if (_isDragging)
        {
            if (Input.touchCount == 2)
            {
                Vector2 currentTouchPos = (Input.GetTouch(0).position + Input.GetTouch(1).position) / 2.0f;
                Vector2 deltaTouchPos = currentTouchPos - _initialTouchPos;

                // Panning
                transform.position += new Vector3(deltaTouchPos.x, deltaTouchPos.y, 0) * Time.deltaTime;

                // Scaling
                float distance = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
                float scaleFactor = distance / (_initialTouchPos - _initialScale).magnitude;

                _currentScale = Mathf.Clamp(_initialScale.x * scaleFactor, minScale, maxScale);

                transform.localScale = new Vector3(_currentScale, _currentScale, 1f);
            }
        }
    }
}
