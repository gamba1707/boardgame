using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReStart : MonoBehaviour
{
    public GameObject Ball;
    Vector3 StartPos;
    //Quaternion StartRot;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = new Vector3(14,-21,-7);
        //StartRot = new Quaternion();
        Ball = GameObject.FindGameObjectWithTag ("ball");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            //DestroyとInstantiateよりも座標移動の方が処理かるいかも
            //Destroy(Ball);
            //Instantiate(Ball, StartPos, StartRot);

            Ball.transform.position = StartPos;
            Ball = GameObject.FindGameObjectWithTag("ball");
        }
    }
}
