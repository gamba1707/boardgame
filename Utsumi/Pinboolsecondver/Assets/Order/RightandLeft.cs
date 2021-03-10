using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RightandLeft : MonoBehaviour
{
    public GameObject Flip1;
    public GameObject Flip2;
    public Rigidbody rig1;
    public Rigidbody rig2;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rig1 = Flip1.GetComponent<Rigidbody>();
        rig2 = Flip2.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rig1.transform.Rotate(new Vector3(0, -speed, 0));
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rig1.transform.Rotate(new Vector3(0, speed, 0));
        }
        if (Input.GetKey(KeyCode.J))
        {
            rig2.transform.Rotate(new Vector3(0, -speed, 0));
        }

        if (Input.GetKey(KeyCode.L))
        {
            rig2.transform.Rotate(new Vector3(0, speed, 0));
        }

    }
}
