using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSystem : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 tmp;
    public GameObject stick;

    public void SetQue()
    {
        stick.transform.localPosition = new Vector3(tmp.x, tmp.y, tmp.z);
        rb.isKinematic = true;
        rb.detectCollisions = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = stick.GetComponent<Rigidbody>();
        tmp = stick.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }
}
