using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour

{
	/// <summary>
	/// 衝突した時
	/// </summary>
	/// <param name="collision"></param>
	/// 
	void OnCollisionEnter(Collision collision)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (collision.gameObject.tag == "ScaleObject")
		{
			// 自分自身の大きさを変える(例としてx,y,z方向に2倍の大きさにしている）
			GetComponent<Transform>().localScale = new Vector3(2f, 2f, 2f);
		}
	}
}