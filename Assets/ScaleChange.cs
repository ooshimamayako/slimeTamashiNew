using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    /// <summary>
	/// 衝突した時
	/// </summary>
	/// <param name="collision"></param>
	void OnCollisionEnter(Collision collision)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (collision.gameObject.tag == "building")
        {
            Vector3 kero;  //①仮の変数宣言

            kero = gameObject.transform.localScale; //◆現在の大きさを代入
  
            //double v = 0.2;
            //kero.x = kero.x + v;
            //kero.y = kero.x + 1;
            //kero.z = kero.x + 1;
            //②変数keroのx座標を1増やして代入

            gameObject.transform.localScale = kero; //③大きさに変数keroを代入
        }
    }

}
