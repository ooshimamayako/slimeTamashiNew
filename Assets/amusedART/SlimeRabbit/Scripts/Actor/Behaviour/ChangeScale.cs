using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour

{
	/// <summary>
	/// �Փ˂�����
	/// </summary>
	/// <param name="collision"></param>
	/// 
	void OnCollisionEnter(Collision collision)
	{
		// �Փ˂��������Player�^�O���t���Ă���Ƃ�
		if (collision.gameObject.tag == "ScaleObject")
		{
			// �������g�̑傫����ς���(��Ƃ���x,y,z������2�{�̑傫���ɂ��Ă���j
			GetComponent<Transform>().localScale = new Vector3(2f, 2f, 2f);
		}
	}
}