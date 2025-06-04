using UnityEngine;

public class PlayerLine : MonoBehaviour
{
    private LineRenderer lineRenderer;
    [SerializeField] private Transform targetPoint;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

        if (lineRenderer == null)
        {
            enabled = false;
        
            return;
        }

        lineRenderer.positionCount = 2;
    }

    void Update()
    {
        if (targetPoint == null) return;

        Vector3 startPos = transform.position;
        Vector3 endPos = targetPoint.position;

        lineRenderer.SetPosition(0, startPos);
        lineRenderer.SetPosition(1, endPos);
    }
}
