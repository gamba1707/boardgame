using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflect : MonoBehaviour
{
    
    public float addforce;
    public Vector3 vec;
    public int typ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void REflect() {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (typ == 0)
        {
            if (collision.gameObject.tag == "Boll")
            {
                collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                collision.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, addforce);

            }
        }
        if (typ == 1)
        {
            if (collision.gameObject.tag == "Boll")
            {
                collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                collision.gameObject.GetComponent<Rigidbody>().AddForce(0, addforce, 0);

            }
        }
        if (typ == 2)
        {
            if (collision.gameObject.tag == "Boll")
            {
                collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                collision.gameObject.GetComponent<Rigidbody>().AddForce(addforce, 0, 0);

            }
        }
    }
}
