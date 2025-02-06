using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WallController : MonoBehaviour
{
    private GameObject unitychan;//Unityちゃんのオブジェクト
    private float difference;    //Unityちゃんと壁の距離
    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find ("unitychan");
        //Unityちゃんと壁の位置（z座標）の差
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせて壁の位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z-difference);
    }
    
    void OnTriggerEnter(Collider other)  // 衝突した場合の処理
    {
        Debug.Log("("+other.gameObject.tag+")");
       if (other.gameObject.tag == "CarTag")
        {
             Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "TrafficConeTag")
        {
             Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "CoinTag")
        {
             Destroy(other.gameObject);
        }
    }
}
