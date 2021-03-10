using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gra : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, speed));
    }
}
