using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public Transform ball;
    private Vector3 offset;

    public Rigidbody rb;
    public float jumpMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        offset = ball.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position - offset;
        Vector2 inputRaw = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        Vector2 inputDir = inputRaw.normalized;

        Vector3 translation = Vector3.zero;

        translation += transform.forward * inputDir.y;
        translation += transform.right * inputDir.x;

        Vector3 velocity = translation * speed;

        ball.Translate(velocity * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpMultiplier, ForceMode.Impulse);
        }
    }
}
