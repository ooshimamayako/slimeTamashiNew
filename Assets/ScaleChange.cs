using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    /// <summary>
	/// �Փ˂�����
	/// </summary>
	/// <param name="collision"></param>
	void OnCollisionEnter(Collision collision)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "building")
        {
            Vector3 kero;  //�@���̕ϐ��錾

            kero = gameObject.transform.localScale; //�����݂̑傫������
  
            //double v = 0.2;
            //kero.x = kero.x + v;
            //kero.y = kero.x + 1;
            //kero.z = kero.x + 1;
            //�A�ϐ�kero��x���W��1���₵�đ��

            gameObject.transform.localScale = kero; //�B�傫���ɕϐ�kero����
        }
    }

}
