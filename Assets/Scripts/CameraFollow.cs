using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // camera will follow this object
    public Transform Target;
    //camera transform
    public Transform camTransform;

    [SerializeField]
    private float yOffset = 1.0f;

    [SerializeField]
    private float distanceMultiplier = 1.0f;

    // change this value to get desired smoothness
    public float SmoothTime = 0.3f;

    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        yOffset = camTransform.position.y - Target.position.y;
    }

    private void LateUpdate()
    {
        // update position
        Vector3 targetPosition = Target.position - (Target.forward * distanceMultiplier);// ((Target.forward + Offset) * distanceMultiplier);
        targetPosition += Vector3.up * yOffset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);

        // update rotation
        transform.LookAt(Target);
    }
}