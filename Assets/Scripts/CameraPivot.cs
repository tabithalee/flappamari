using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    // The target marker.
    public GameObject gameCamera;
    public GameObject sphere;

    // Angular speed in radians per sec.
    public float angle = -25f;

    public IEnumerator PivotSphere()
    {
        gameCamera.transform.RotateAround(sphere.transform.position, Vector3.up, angle);
        yield return new WaitForSeconds(2);
        Debug.Log("finished pivot");
    }
}
