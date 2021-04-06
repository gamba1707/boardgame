using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{
    Rigidbody rb;
    float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BoundObj")
        {
            x = rb.velocity.x * 5f;
            y = rb.velocity.x * 5f;
            //z = -rb.velocity.z * 5f;
            if (x > 100) x = 30;
            if (x < -100) x = -30;
            if (y > 100) y = 30;
            if (y < -100) y = -30;
            rb.velocity = new Vector3(x, y, 0);
            Debug.Log("Bound");
        }
    }
}
