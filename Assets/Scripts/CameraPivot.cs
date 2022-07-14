using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    // The target marker.
    public GameObject ballParent;

    // Angular speed in radians per sec.
    public float angle = 45f;

    public IEnumerator PivotSphere()
    {
        ballParent.transform.RotateAround(ballParent.transform.position, Vector3.up, angle);
        yield return new WaitForSeconds(2);
        Debug.Log("finished pivot");
    }
}
