using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    private Vector3 ini;
    private GameObject BallObj;
    private Rigidbody BallRb;

    // Start is called before the first frame update
    void Start()
    {
        BallObj = GameObject.Find("Ball_00");
        BallRb = BallObj.GetComponent<Rigidbody>();
        ini = target.position;
        offset = GetComponent<Transform>().position - ini;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Rigidbody.IsSleeping() || target == ini)
        //ボールが止まったとき
        /*
        if(ballRigid.IsSleeping())
        {
            Debug.Log("CameraMoved");
            GetComponent<Transform>().position = target.position + offset;
        }
        */
        //座標変化が微量の時、止める
        if (BallRb.velocity.magnitude < 0.1f)
        {
            //Debug.Log("stop");
            BallRb.velocity = Vector3.zero;
            BallRb.gameObject.transform.rotation = Quaternion.Euler(Vector3.zero);
            GetComponent<Transform>().position = target.position + offset;
        }
    }
}
