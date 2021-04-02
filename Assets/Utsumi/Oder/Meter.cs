using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meter : MonoBehaviour
{
    public GameObject ball;
    public float lang;
    public float Z;
    public float Y;
    // Start is called before the first frame update
    void Start()
    {
        Z = this.gameObject.transform.position.z;
        Y = this.gameObject.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.localPosition = new Vector3(this.gameObject.transform.position.x, Y + lang * ball.GetComponent<AddEnerlgy>().time, Z + lang * ball.GetComponent<AddEnerlgy>().time*Mathf.Sqrt(3));
    }
}
