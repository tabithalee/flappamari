using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    // The target marker.
    public Vector3 targetDirection;
    public Transform sphereParent;

    // Angular speed in radians per sec.
    public float speed = 5.0f;

    public void PivotSphere()
    {
        // Determine which direction to rotate towards
        Vector3 targetDirection = Vector3.left;

        // The step size is equal to speed times frame time.
        float singleStep = speed * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(sphereParent.forward, targetDirection, singleStep, 0.0f);

        // Draw a ray pointing at our target in
        Debug.DrawRay(sphereParent.position, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
