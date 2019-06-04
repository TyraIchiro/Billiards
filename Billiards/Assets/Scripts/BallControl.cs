using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey(KeyCode.UpArrow) )
        {
            rb.AddForce(transform.forward * movementSpeed);
            // transform.position += Vector3.back * movementSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // transform.position += Vector3.forward * movementSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // transform.position += Vector3.left * movementSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // transform.position += Vector3.right * movementSpeed;
        }
    }
}
