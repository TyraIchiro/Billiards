using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceBall : MonoBehaviour
{
    // 上の向きに加わる力の大きさを定義
    public float forceMagnitude = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            AddForce(new Vector3(1.0f, 0f, 0f));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            AddForce(new Vector3(-1.0f, 0f, 0f));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            AddForce(new Vector3(0f, 0f, -1.0f));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            AddForce(new Vector3(0f, 0f, 1.0f));
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
