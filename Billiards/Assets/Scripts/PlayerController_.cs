using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_ : MonoBehaviour
{
    //キャラクターコントローラー
    private CharacterController cCon;
    //　キャラクターの速度
    private Vector3 velocity;
    //　キャラクター視点のカメラ
    private Transform myCamera;
    //　キャラクター視点のカメラで回転出来る限度
    [SerializeField]
    private float cameraRotateLimit = 30f;
    //　カメラの上下の移動方法。マウスを上で上を向く場合はtrue、マウスを上で下を向く場合はfalseを設定
    [SerializeField]
    private bool cameraRotForward = true;
    //　カメラの角度の初期値
    private Quaternion initCameraRot;
    //　キャラクター、カメラ（視点）の回転スピード
    [SerializeField]
    private float rotateSpeed = 2f;
    //　カメラのX軸の角度変化値
    private float xRotate;
    //　キャラクターのY軸の角度変化値
    private float yRotate;
    //　マウス移動のスピード
    [SerializeField]
    private float mouseSpeed = 2f;
    //　キャラクターのY軸の角度
    private Quaternion charaRotate;
    //　カメラのX軸の角度
    private Quaternion cameraRotate;

    // Start is called before the first frame update
    void Start()
    {
        //キャラクターコントローラの取得
        cCon = GetComponent<CharacterController>();
        myCamera = GetComponentInChildren<Camera>().transform;  //　キャラクター視点のカメラの取得
        initCameraRot = myCamera.rotation;
        charaRotate = transform.rotation;
        cameraRotate = myCamera.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //　キャラクターの向きを変更する
        RotateChara();
        //　視点の向きを変える
        RotateCamera();

        //　キャラクターコントローラのコライダが地面と接触してるかどうか
        if (cCon.isGrounded)
        {
            velocity = Vector3.zero;
            velocity = (-transform.forward * Input.GetAxis("Vertical") + -transform.right * Input.GetAxis("Horizontal")).normalized;
        }
        velocity.y += Physics.gravity.y * Time.deltaTime; //　重力値を計算
        cCon.Move(velocity * Time.deltaTime); //　キャラクターコントローラのMoveを使ってキャラクターを移動させる
    }
    //　キャラクターの角度を変更
    void RotateChara()
    {
        //　横の回転値を計算
        float xRotate = Input.GetAxis("Mouse X") * mouseSpeed;

        charaRotate *= Quaternion.Euler(0f, xRotate, 0f);

        //　キャラクターの回転を実行
        transform.localRotation = Quaternion.Slerp(transform.localRotation, charaRotate, rotateSpeed * Time.deltaTime);
    }
    //　カメラの角度を変更
    void RotateCamera()
    {
        float yRotate = Input.GetAxis("Mouse Y") * mouseSpeed;

        //　マウスを上に移動した時に上を向かせたいなら反対方向に角度を反転させる
        if (cameraRotForward)
        {
            yRotate *= -1;
        }
        //　一旦角度を計算する	
        cameraRotate *= Quaternion.Euler(-yRotate, 0f, 0f);
        //　カメラのY軸の角度が限界角度を超えたら限界角度に設定
        var resultYRot = Mathf.Clamp(Mathf.DeltaAngle(initCameraRot.eulerAngles.y, cameraRotate.eulerAngles.y), -cameraRotateLimit, cameraRotateLimit);
        //　角度を再構築
        cameraRotate = Quaternion.Euler(resultYRot, cameraRotate.eulerAngles.y, cameraRotate.eulerAngles.z);
        //　カメラの視点変更を実行
        myCamera.localRotation = Quaternion.Slerp(myCamera.localRotation, cameraRotate, rotateSpeed * Time.deltaTime);
    }
}
