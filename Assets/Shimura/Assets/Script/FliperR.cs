using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliperR : MonoBehaviour
{
    //Inspecterの値を変更
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
        //AxisLとAxisRを探す
        GameObject fliperL = GameObject.Find("Fliper_left");
        GameObject fliperR = GameObject.Find("Fliper_right");

        //HingeJointを受け取る
        hjL = fliperL.GetComponent<HingeJoint>();
        hjR = fliperR.GetComponent<HingeJoint>();

        //Springを受け取る
        jL = hjL.spring;
        jL = hjR.spring;
    }

    // Update is called once per frame
    void Update()
    {
        // 左クリックを押す
        if (Input.GetKeyDown(KeyCode.A))
        {
            jL.spring = spring;
            jL.targetPosition = openAngle;
            hjL.spring = jL;

        }
        // 左クリックを離す
        if (Input.GetKeyUp(KeyCode.A))
        {
            jL.spring = spring;
            jL.targetPosition = closeAngle;
            hjL.spring = jL;
        }
        // 右クリックを押す
        if (Input.GetKeyDown(KeyCode.D))
        {
            jR.spring = spring;
            jR.targetPosition = -openAngle;
            hjR.spring = jR;
        }
        // 右クリックを離す
        if (Input.GetKeyUp(KeyCode.D))
        {
            jR.spring = spring;
            jR.targetPosition = closeAngle;
            hjR.spring = jR;
        }
    }
}
