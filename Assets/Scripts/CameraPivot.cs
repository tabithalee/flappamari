using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    // The target marker.
    public GameObject gameCamera;
    public GameObject sphere;

    // Angular speed in radians per sec.
    public float angle = 90f;

    public IEnumerator PivotSphere()
    //{
    //    // Determine which direction to rotate towards
    //    Vector3 targetDirection = Vector3.left;

    //    // The step size is equal to speed times frame time.
    //    float singleStep = speed * Time.deltaTime;

    //    // Rotate the forward vector towards the target direction by one step
    //    Vector3 newDirection = Vector3.RotateTowards(sphereParent.forward, targetDirection, singleStep, 0.0f);

    //    // Draw a ray pointing at our target in
    //    Debug.DrawRay(sphereParent.position, newDirection, Color.red);

    //    // Calculate a rotation a step closer to the target and applies rotation to this object
    //    sphereParent.rotation = Quaternion.LookRotation(newDirection);
    //}
    {
        gameCamera.transform.RotateAround(sphere.transform.position, Vector3.up, angle);
        yield return new WaitForSeconds(5);
        Debug.Log("finished pivot");
    }
}
