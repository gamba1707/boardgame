using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliperR : MonoBehaviour
{
    //Inspecter�̒l��ύX
    public float spring = 40000;
    public float openAngle = 60;
    public float closeAngle = 0;

    //HingeJoint
    private HingeJoint hjL;
    private HingeJoint hjR;

    //JointSpring
    private JointSpring jL;
    private JointSpring jR;

    void Start()
    {
        //AxisL��AxisR��T��
        GameObject fliperL = GameObject.Find("Fliper_left");
        GameObject fliperR = GameObject.Find("Fliper_right");

        //HingeJoint���󂯎��
        hjL = fliperL.GetComponent<HingeJoint>();
        hjR = fliperR.GetComponent<HingeJoint>();

        //Spring���󂯎��
        jL = hjL.spring;
        jL = hjR.spring;
    }

    // Update is called once per frame
    void Update()
    {
        // ���N���b�N������
        if (Input.GetKeyDown(KeyCode.A))
        {
            jL.spring = spring;
            jL.targetPosition = openAngle;
            hjL.spring = jL;

        }
        // ���N���b�N�𗣂�
        if (Input.GetKeyUp(KeyCode.A))
        {
            jL.spring = spring;
            jL.targetPosition = closeAngle;
            hjL.spring = jL;
        }
        // �E�N���b�N������
        if (Input.GetKeyDown(KeyCode.D))
        {
            jR.spring = spring;
            jR.targetPosition = -openAngle;
            hjR.spring = jR;
        }
        // �E�N���b�N�𗣂�
        if (Input.GetKeyUp(KeyCode.D))
        {
            jR.spring = spring;
            jR.targetPosition = closeAngle;
            hjR.spring = jR;
        }
    }
}
