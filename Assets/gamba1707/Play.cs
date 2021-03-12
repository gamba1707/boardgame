using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    Rigidbody rb;
    bool lnot,lstop;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    void Update()
    {
        //Debug.Log(transform.localEulerAngles.y-361);
        //Debug.Log(lnot);
        if (transform.localEulerAngles.y - 361 >= -55 )//a
        {
            if (Input.GetButton("L"))
            {
                transform.Rotate(new Vector3(0, -Input.GetAxis("L") * 10f, 0));
            }
            
        }
        if (lnot)
        {
            transform.Rotate(new Vector3(0, 1, 0));
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("lcheck"))
        {
            lnot = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name.Equals("lcheck"))
        {
                lnot = true;
        }
    }
}
