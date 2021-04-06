using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEnerlgy : MonoBehaviour
{
    public float limittime;
    public float add;
    public float time;
    public GameObject gam;
    public bool s;
    public Vector3 vec;
    [SerializeField, Range(0, 1000)] public int Range;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.y <= -20)
        {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            this.gameObject.transform.localPosition = vec;
        }
        if (Input.GetKey(KeyCode.Q)) { gam.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-1,2)*Range, 0, 0)); counter++; if (counter >= 10) { score.point-=10000; } }
        

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
                gam.GetComponent<Rigidbody>().AddForce(new Vector3(0, time * add*0.5f, 0.5f*Mathf.Sqrt(3)* time * add));
                time = 0;
                s = false;
            }
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Start")
        {
            s = true;
        }
    }
}
