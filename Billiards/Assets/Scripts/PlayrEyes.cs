using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayrEyes : MonoBehaviour
{
    private Transform verRot;
    private Transform horRot;

    // Start is called before the first frame update
    void Start()
    {
        verRot = transform.parent;
        horRot = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        verRot.transform.Rotate(0, X_Rotation, 0);
        horRot.transform.Rotate(-Y_Rotation, 0, 0);
    }
}
