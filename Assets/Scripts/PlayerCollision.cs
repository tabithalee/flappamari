using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.tag)
        {
            case "ground":
                break;
            case "boss":
                Debug.Log("oh it's the boss!");
                break;
            default:
                Debug.Log("yowza i think i hit a wall");
                break;
        }
    }
}
