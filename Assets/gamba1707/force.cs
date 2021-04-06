using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    public GameObject ball;
    Rigidbody ballrb;
    float x;
    bool downon,ballon;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        ballrb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.localPosition);
        
        if (Input.GetButtonDown("Down"))
        {
            downon = true;
        }
        if (Input.GetButtonUp("Down"))
        {
            downon = false;
            if (ballon)
            {
                Debug.Log("wow!");
                ballrb.velocity=new Vector3(0,0,x*35);
            }
            x = 0;
            StartCoroutine("back");
        }
        if (downon)
        {
            if (x <= 1)
            {
                x += 0.001f;
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.001f);
            }
        }
    }

    IEnumerator back()
    {
        while (true)
        {
            transform.localPosition = Vector3.Lerp(transform.position, new Vector3(5.71f, 5.8f, -10f), Time.deltaTime*0.1f);
            if (transform.localPosition.z >= -10f)
            {
                break;
            }
            yield return null;
        }
        yield return null;
        transform.localPosition = new Vector3(5.71f, 5.8f, -10f);
        yield break;
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag.Equals("ball"))
        {
            ballon = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag.Equals("ball"))
        {
            ballon = false;
        }
    }
}
