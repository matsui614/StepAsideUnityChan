using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    //アニメーションするためのコンポーネントを入れる
    private Animator myAnimator;
    //Unityちゃんを移動させるコンポーネントを入れる
    private Rigidbody myRigidbody;
    //前方向の速度
    private float velocityZ = 16f;
    // Start is called before the first frame update
    void Start ()
    {

        //Animatorコンポーネントを取得
        this.myAnimator = GetComponent<Animator>();

        //走るアニメーションを開始
        this.myAnimator.SetFloat ("Speed", 1);

        //Rigidbodyコンポーネントを取得
        this.myRigidbody.velocity = new Vector3(0, 0, this.velocityZ);
    }
    void Update ()
    {

    }
}