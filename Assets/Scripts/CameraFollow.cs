using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform target; 

    [SerializeField]
    private Vector3 offset;

    [SerializeField]
    private float smoothSpeed = 0.125f; 

    private void LateUpdate()
    {
        Vector3 desiredPosition = new Vector3(transform.position.x, target.position.y <= -237.0968f ? -237.0968f : target.position.y, -10) + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
