using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpManager : MonoBehaviour
{
    public static int WarpNumber;
    public static bool WarpSwicth;
    GameObject Ball;
    GameObject WarpHoleEntrance;//���[�v�z�[������
    GameObject WarpHoleExit;//���[�v�z�[���o��
    Vector3 BallPos;
    // Start is called before the first frame update
    void Start()
    {
        WarpNumber = 0;
        Ball = GameObject.FindGameObjectWithTag("ball");

        //�����p�Əo���p�̃��[�v�z�[����T��
        WarpHoleEntrance = GameObject.FindGameObjectWithTag("WarpHoleEntrance");
        WarpHoleExit = GameObject.FindGameObjectWithTag("WarpHoleExit");

        if (WarpSwicth == true)
        {
            BallPos = new Vector3(WarpHoleExit.transform.position.x,
                WarpHoleExit.transform.position.y,
                WarpHoleExit.transform.position.z);
            Ball.transform.position = BallPos;
            Debug.Log("WarpHolePos;"+WarpHoleExit.transform.position);            
            Debug.Log("BallPos;"+BallPos);
            Debug.Log("Ball;" + Ball.transform.position);
        }
        WarpSwicth = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
