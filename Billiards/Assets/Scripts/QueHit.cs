using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueHit : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 tmp;

    // Start is called before the first frame update
    void Start()
    {
        tmp = this.transform.localPosition;
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
        this.transform.localPosition = new Vector3(tmp.x, tmp.y, tmp.z);
        rb.isKinematic = true;
        rb.detectCollisions = false;
    }
}
