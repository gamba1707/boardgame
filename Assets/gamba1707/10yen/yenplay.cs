using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yenplay : MonoBehaviour
{
    public GameObject R_jiku, L_jiku,yen;
    HingeJoint jR, jL;
    JointSpring jsR, jsL;
    static float L_tuyo, R_tuyo;
    bool stop;
    // Start is called before the first frame update
    void Start()
    {
        jL =L_jiku.GetComponent<HingeJoint>();
        jsL = jL.spring;
        jR = R_jiku.GetComponent<HingeJoint>();
        jsR = jR.spring;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Down"))
        {
            stop = true;
        }
        if (Input.GetButtonUp("Down"))
        {
            stop = false;
        }
            if (Input.GetButton("L"))
        {
            Debug.Log("ok");
            jsL.spring = 45000;
            if(L_tuyo<=20&&stop==false) L_tuyo += 0.025f;
            jsL.targetPosition = L_tuyo;
            jL.spring = jsL;
        }
        if (Input.GetButtonUp("L"))
        {
            jsL.spring = 45000;
            L_tuyo = -10;
            jsL.targetPosition = -10;
            jL.spring = jsL;
        }
        if (Input.GetButton("R"))
        {
            jsR.spring = 45000;
            if (R_tuyo>=-30 && stop == false) R_tuyo -= 0.025f;
            jsR.targetPosition = R_tuyo;
            jR.spring = jsR;
        }
        if (Input.GetButtonUp("R"))
        {
            jsR.spring = 45000;
            R_tuyo = 10;
            jsR.targetPosition = 10;
            jR.spring = jsR;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            yen.transform.position = new Vector3(5.48f,9.25f,-8.33f);
        }
    }
}
