using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueOpe : MonoBehaviour
{
    static float forceMagnitude;
    public GameObject objA;
    private float scroll;
    public float speed = 1f;
    static float dis1;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 posB_1 = this.transform.position;
        Vector3 posB_2 = objA.transform.position;
        dis1 = Vector3.Distance(posB_1, posB_2);
        // Debug.Log("Distance : " + dis1);
    }

    // Update is called once per frame
    void Update()
    {
        scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 posA_1 = this.gameObject.transform.position;
        Vector3 posA_2 = objA.gameObject.transform.position;
        float dis2 = Vector3.Distance(posA_1, posA_2);
        // Debug.Log("Distance : " + dis2);

        this.gameObject.transform.localPosition += -transform.forward * scroll * speed;
        if (Input.GetMouseButtonDown(0))
        {
            if ( dis2 >= dis1 && dis2 < 1.5f )
            {
                forceMagnitude = 10.0f;
            }
            else if (dis2 >= 1.5f && dis2 < 1.8f)
            {
                forceMagnitude =12.0f;
            }
            else if (dis2 >= 1.8f && dis2 < 2.2f)
            {
                forceMagnitude = 15.0f;
            }
            else
            {
                forceMagnitude = 0;
            }
            AddForce(this.gameObject.transform.forward);
        }
    }

    void AddForce(Vector3 forceDirection)
    {
        // 向きと大きさからSphereに加わる力を計算する
        Vector3 force = forceMagnitude * forceDirection;

        // SphereオブジェクトのRigidbodyコンポーネントへの参照を取得
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        // 力を加えるメソッド
        // ForceMode.Impulseは撃力
        rb.AddForce(force, ForceMode.Impulse);
    }
}
