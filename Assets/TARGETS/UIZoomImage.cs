using UnityEngine;
using UnityEngine.EventSystems;

public class UIZoomImage : MonoBehaviour, IScrollHandler
{
    private Vector3 initialScale;

    [SerializeField]
    public float zoomSpeed = 0.1f;
    [SerializeField]
    public float maxZoom = 5f;

    private void Awake()
    {
        initialScale = transform.localScale;
    }

    public void OnScroll(PointerEventData eventData)
    {
        Debug.Log(eventData.scrollDelta.y);
        var delta = Vector3.one * (eventData.scrollDelta.y * zoomSpeed);
        var desiredScale = transform.localScale + delta;
        transform.localScale = ClampDesiredScale(desiredScale);
    }

    private Vector3 ClampDesiredScale(Vector3 desiredScale)
    {
        desiredScale = Vector3.Max(initialScale, desiredScale);
        desiredScale = Vector3.Min(initialScale * maxZoom, desiredScale);
        return desiredScale;
    }
}
