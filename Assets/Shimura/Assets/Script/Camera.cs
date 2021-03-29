using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Ball;
    float Ypos;
    float Zpos;
    public float YDistance;
    public float ZDistance;
    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("ball");
        Ypos = Ball.transform.position.y + YDistance;
        Zpos = Ball.transform.position.z - ZDistance;
        transform.position = new Vector3(0, Ypos, Zpos);
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.transform.position.y < 2)
        {
            Ypos = Ball.transform.position.y + YDistance;
        }

        //if (Ball.transform.position.z <0)
        //{
        //    Zpos = Ball.transform.position.z - Distance;
        //}
        Zpos = Ball.transform.position.z - ZDistance;
        transform.position = new Vector3(0, Ypos, Zpos);
    }
}
