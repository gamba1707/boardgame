using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play2 : MonoBehaviour
{
    public GameObject R_jiku, L_jiku;
    HingeJoint jR,jL;
    JointSpring jsR,jsL;
    // Start is called before the first frame update
    void Start()
    {
        jL = L_jiku.GetComponent<HingeJoint>();
        jsL = jL.spring;
        jR = R_jiku.GetComponent<HingeJoint>();
        jsR = jR.spring;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("L"))
        {
            Debug.Log("ok");
            jsL.spring = 40000;
            jsL.targetPosition = 60;
            jL.spring = jsL;
        }
        if (Input.GetButtonUp("L"))
        {
            jsL.spring = 40000;
            jsL.targetPosition = 0;
            jL.spring = jsL;
        }
        if (Input.GetButton("R"))
        {
            jsR.spring = 40000;
            jsR.targetPosition = -60;
            jR.spring = jsR;
        }
        if (Input.GetButtonUp("R") )
        {
            jsR.spring = 40000;
            jsR.targetPosition = 0;
            jR.spring = jsR;
        }
    }

}
