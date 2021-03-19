using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class re_side : MonoBehaviour
{
    public GameObject hi;
    static int lcount, rcount;
    public Material yellowoff,yellowon;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = yellowoff;
    }

    // Update is called once per frame
    void Update()
    {
        if (rcount == 3)
        {
            hi.SetActive(false);
            rcount = 0;
        }
        if(rcount==0) GetComponent<Renderer>().material = yellowoff;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            
            if (GetComponent<Renderer>().material.name.Equals("yellow_nomal (Instance)"))
            {
                if (gameObject.name.Substring(0, 1).Equals("R"))
                {
                    rcount++;
                    Debug.Log(rcount);
                    GetComponent<Renderer>().material = yellowon;
                }
            }
        }
        
            
    }
}
