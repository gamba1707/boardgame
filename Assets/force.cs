using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    float x;
    bool downon,ballon;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ballon);
        
        if (Input.GetButtonDown("Down"))
        {
            downon = true;
        }
        if (Input.GetButtonUp("Down"))
        {
            downon = false;
        }
        if (downon)
        {
            if (x <= 1)
            {
                x += 0.01f;
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.01f);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag.Equals("ball"))
        {
            ballon = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag.Equals("ball"))
        {
            ballon = false;
        }
    }
}
