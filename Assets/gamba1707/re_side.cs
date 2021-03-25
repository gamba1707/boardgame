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
        if (gameObject.name.Substring(0, 1).Equals("L"))
        {
            if (lcount == 3)
            {
                hi.SetActive(false);
                lcount = 0;
            }
            if (lcount == 0) GetComponent<Renderer>().material = yellowoff;
        }
        if (gameObject.name.Substring(0, 1).Equals("R"))
        {
            if (rcount == 3)
            {
                hi.SetActive(false);
                rcount = 0;
            }
            if (rcount == 0) GetComponent<Renderer>().material = yellowoff;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            
            if (GetComponent<Renderer>().material.name.Equals("yellow_nomal (Instance)"))
            {
                if (gameObject.name.Substring(0, 1).Equals("L"))
                {
                    lcount++;
                    score.addpoint(700);
                    Debug.Log(lcount);
                    GetComponent<Renderer>().material = yellowon;
                }
                if (gameObject.name.Substring(0, 1).Equals("R"))
                {
                    rcount++;
                    score.addpoint(700);
                    Debug.Log(rcount);
                    GetComponent<Renderer>().material = yellowon;
                }
                if (gameObject.name.Substring(0, 1).Equals("c"))
                {
                    score.addpoint(700);
                    GetComponent<Renderer>().material = yellowon;
                }
            }
        }
        
            
    }
}
