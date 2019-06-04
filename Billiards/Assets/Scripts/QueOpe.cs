using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueOpe : MonoBehaviour
{
    void OnMouseDrag()
    {
        Vector3 objectPointInScreen = Camera.main.WorldToScreenPoint(this.transform.position);

        Vector3 mousePointInScreen = new Vector3(Input.mousePosition.x, objectPointInScreen.y, Input.mousePosition.z);

        Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
        mousePointInWorld.y = this.transform.position.y;
        this.transform.position = mousePointInWorld;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
