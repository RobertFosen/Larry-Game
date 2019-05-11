using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 100f;
    public float turnSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            if (!(Input.GetKey("w") || Input.GetKey("s")))
            {
                transform.Rotate(Vector3.up, -(turnSpeed * 2) * Time.deltaTime);
            }
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            if (!(Input.GetKey("w") || Input.GetKey("s"))) {
                transform.Rotate(Vector3.up, (turnSpeed * 2) * Time.deltaTime);
            }
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}