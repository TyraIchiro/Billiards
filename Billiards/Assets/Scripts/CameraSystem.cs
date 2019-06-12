using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera overheadCamera;
    private bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCamera()
    {
        if (flag == true)
        {
            ShowOverheadView();
            flag = false;
        }
        else
        {
            ShowFirstPersonView();
            flag = true;
        }
    }

    void ShowOverheadView()
    {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }

    void ShowFirstPersonView()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }
}
