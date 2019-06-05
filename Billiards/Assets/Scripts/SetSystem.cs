using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSystem : MonoBehaviour
{
    private Rigidbody rb;

    public void SetQue()
    {
        GameObject.Find("Stick").transform.localPosition = new Vector3(0, -0.3f, 1.2f);
        rb.isKinematic = true;
        rb.detectCollisions = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.Find("Stick").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }
}
