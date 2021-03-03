using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ballvelocity:"+rb.velocity);

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("bollcollision:"+collision.gameObject.tag);
        if (collision.gameObject.tag.Equals("Jetbumper"))
        {
            float x = rb.velocity.x * 20f;
            float z = -rb.velocity.z * 20f;
            if (x > 100) x = 100;
            if (x < -100) x = -100;
            if (z > 100) z = 100;
            if (z < -100) z = -100;
            rb.velocity = new Vector3(x, 0, z);
        }
    }
}
