﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO : MonoBehaviour
{
    public float limittime;
    public float add;
    public float time;
    public GameObject gam;
    public bool s;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (s)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                time += Time.deltaTime;
            }
            if (time >= limittime)
            {
                time = 0;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                gam.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, time * add));
                time = 0;
                s = false;
            }
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ON") {
            s = true;
        }
    }
}
