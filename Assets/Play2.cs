using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play2 : MonoBehaviour
{
    public GameObject RFripper;
    HingeJoint jR;
    JointSpring jsR;
    // Start is called before the first frame update
    void Start()
    {
        jR = RFripper.GetComponent<HingeJoint>();
        jsR = jR.spring;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("R"))
        {
            jsR.spring = 40000;
            jsR.targetPosition = -60;
            jR.spring = jsR;
        }
        if (Input.GetButtonUp("R"))
        {
            jsR.spring = 40000;
            jsR.targetPosition = 0;
            jR.spring = jsR;
        }
    }
}
