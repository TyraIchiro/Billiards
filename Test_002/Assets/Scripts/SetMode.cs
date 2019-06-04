using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetMode : MonoBehaviour
{
    public void SetNineBall()
    {
        SceneManager.LoadScene("Billiards_NineBall");
    }

    public void Set14_1()
    {
        /*
        // Vector3 Ball_01 = GameObject.Find("Ball_01").transform.position;
        GameObject.Find("Ball_01").transform.position = new Vector3(0, 0.03855f, -0.725f);
        // Vector3 Ball_02 = GameObject.Find("Ball_02").transform.position;
        GameObject.Find("Ball_02").transform.position = new Vector3(-0.1142f, 0.03855f, -0.9228003f);
        // Vector3 Ball_03 = GameObject.Find("Ball_03").transform.position;
        GameObject.Find("Ball_03").transform.position = new Vector3(0.1142f, 0.03855f, -0.9228003f);
        // Vector3 Ball_04 = GameObject.Find("Ball_04").transform.position;
        GameObject.Find("Ball_04").transform.position = new Vector3(-0.0571f, 0.03855f, -0.9228003f);
        // Vector3 Ball_05 = GameObject.Find("Ball_05").transform.position;
        GameObject.Find("Ball_05").transform.position = new Vector3(0, 0.03855f, -0.9228003f);
        // Vector3 Ball_06 = GameObject.Find("Ball_06").transform.position;
        GameObject.Find("Ball_06").transform.position = new Vector3(0.0571f, 0.03855f, -0.9228003f);
        // Vector3 Ball_07 = GameObject.Find("Ball_07").transform.position;
        GameObject.Find("Ball_07").transform.position = new Vector3(-0.02855f, 0.03855f, -0.7744501f);
        // Vector3 Ball_08 = GameObject.Find("Ball_08").transform.position;
        GameObject.Find("Ball_08").transform.position = new Vector3(0.02855f, 0.03855f, -0.7744501f);
        // Vector3 Ball_09 = GameObject.Find("Ball_09").transform.position;
        GameObject.Find("Ball_09").transform.position = new Vector3(-0.08565f, 0.03855f, -0.8733503f);
        // Vector3 Ball_10 = GameObject.Find("Ball_10").transform.position;
        GameObject.Find("Ball_10").transform.position = new Vector3(0.08565f, 0.03855f, -0.8733503f);
        // Vector3 Ball_11 = GameObject.Find("Ball_11").transform.position;
        GameObject.Find("Ball_11").transform.position = new Vector3(-0.0571f, 0.03855f, -0.8239002f);
        // Vector3 Ball_12 = GameObject.Find("Ball_12").transform.position;
        GameObject.Find("Ball_12").transform.position = new Vector3(0, 0.03855f, -0.8239002f);
        // Vector3 Ball_13 = GameObject.Find("Ball_13").transform.position;
        GameObject.Find("Ball_13").transform.position = new Vector3(0.0571f, 0.03855f, -0.8239002f);
        // Vector3 Ball_14 = GameObject.Find("Ball_14").transform.position;
        GameObject.Find("Ball_14").transform.position = new Vector3(-0.02855f, 0.03855f, -0.8733503f);
        // Vector3 Ball_15 = GameObject.Find("Ball_15").transform.position;
        GameObject.Find("Ball_15").transform.position = new Vector3(0.02855f, 0.03855f, -0.8733503f);
        */

        SceneManager.LoadScene("Billiards_14_1");
    }

    public void Back()
    {
        SceneManager.LoadScene("Title");
    }

    // Start is called before the first frame update
    void Start()
    {
        /*
        // Vector3 Ball_00 = GameObject.Find("Ball_00").transform.position;
        GameObject.Find("Ball_00").transform.position = new Vector3(0, 0.03855f, 0.725f);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
