using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float speed = 5;
    public float degreesPerUpdate = 20;
    public Transform ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputRaw = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 inputDir = inputRaw.normalized;

        // prevent snapping back to 0 rotation if no input
        if (inputDir.x != 0)
        {
            ball.Rotate(new Vector3(0, 0, inputDir.x * degreesPerUpdate), Space.World);
        }

        if (inputDir.y != 0)
        {
            ball.Rotate(new Vector3(-1 * inputDir.y * degreesPerUpdate, 0, 0), Space.World);
        }

        //Vector2 inputRaw = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        //Vector2 inputDir = -1 * inputRaw.normalized;

        //Vector3 translation = Vector3.zero;

        //translation += transform.forward * inputDir.y;
        //translation += transform.right * inputDir.x;

        //Vector3 velocity = translation * speed;

        //transform.Translate(velocity * Time.deltaTime, Space.World);
    }
}
