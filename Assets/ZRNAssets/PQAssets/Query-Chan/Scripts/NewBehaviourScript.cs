using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MoveCamera : MonoBehaviour
{
    GameObject target;
    Vector3 targetPos;

    void Start()
    {
        //�ǔ��ړI�̃I�u�W�F�N�g�������ď����擾
        target = GameObject.Find("Robo2");
    }

    void Update()
    {
        //Robot2���ړ��������A�J�������ړ�
        transform.position += target.transform.position - targetPos;
        targetPos = target.transform.position;

        //Robo2�𒆐S��Y�����Ƃ��ĉ�]
        transform.RotateAround(targetPos, Vector3.up, 50.0f * Time.deltaTime);

    }
}