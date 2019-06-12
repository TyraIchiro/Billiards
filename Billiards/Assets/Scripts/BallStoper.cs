using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStoper : MonoBehaviour
{
    private GameObject BallObj;
    private Rigidbody BallRb;

    // Start is called before the first frame update
    void Start()
    {
        BallObj = this.gameObject;
        BallRb = BallObj.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BallRb.velocity.magnitude < 0.05f)
        {
            BallRb.velocity = Vector3.zero;
            BallRb.gameObject.transform.rotation = Quaternion.Euler(Vector3.zero);
        }
    }
}
