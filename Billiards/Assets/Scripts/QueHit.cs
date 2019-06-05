using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueHit : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }
    void OnCollisionEnter(Collision collision)
    {
        transform.localPosition = new Vector3(0, -0.3f, 1.2f);
        rb.isKinematic = true;
        rb.detectCollisions = false;
    }
}
