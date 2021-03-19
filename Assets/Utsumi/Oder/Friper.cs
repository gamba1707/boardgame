using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friper : MonoBehaviour
{
    public float spring = 40000;
    public float openAngle = 60; // 開く角度
    public float closeAngle = 0; // 閉じる角度

    // Hinge Joint
    private HingeJoint hjL; // AxisL
    private HingeJoint hjR; // AxisR

    // JointSpring
    private JointSpring jL; // AxisL
    private JointSpring jR; // AxisR
    public GameObject RightFrip;
    public GameObject LedtFrip;
    void Start()
    {
        // AxisLとAxisRを探す
        GameObject flipperL = LedtFrip;
        GameObject flipperR = RightFrip;

        // HingeJointを受け取る
        hjL = flipperL.GetComponent<HingeJoint>();
        hjR = flipperR.GetComponent<HingeJoint>();

        // Springを受け取る
        jL = hjL.spring;
        jR = hjR.spring;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            jL.spring = spring;
            jL.targetPosition = openAngle;
            hjL.spring = jL;

        }
        
        if (Input.GetKeyUp(KeyCode.A))
        {
            jL.spring = spring;
            jL.targetPosition = closeAngle;
            hjL.spring = jL;
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            jR.spring = spring;
            jR.targetPosition = -openAngle;
            hjR.spring = jR;
        }
        
        if (Input.GetKeyUp(KeyCode.D))
        {
            jR.spring = spring;
            jR.targetPosition = closeAngle;
            hjR.spring = jR;
        }
    }
}
