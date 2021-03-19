using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class side : MonoBehaviour
{
    public GameObject ball,hi;
    Rigidbody rb;
    bool ballin;
    // Start is called before the first frame update
    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            
                StartCoroutine("ballmove");
                ballin = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            ballin = false;
        }
    }
    IEnumerator ballmove()
    {
        yield return new WaitForSeconds(1.5f);
        if (ballin)
        {
            rb.velocity = new Vector3(0, 0,25f);
            yield return new WaitForSeconds(0.5f);
            hi.SetActive(true);
        }
        else yield break;
    }
}
