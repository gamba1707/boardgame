using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class re_side : MonoBehaviour
{
    public GameObject hi;
    GameObject[] lights;
    public static int lcount, rcount, entercount, lightstate;
    static float statetime;
    public Material yellowoff, yellowon;
    private AudioSource sound01;
    // Start is called before the first frame update
    void Start()
    {
        sound01 = GetComponent<AudioSource>();
        lights = GameObject.FindGameObjectsWithTag("light");
        lightstate = 1;
        GetComponent<Renderer>().material = yellowoff;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Mathf.Floor(statetime));

        if (gameObject.name.Substring(0, 1).Equals("L"))
        {
            if (lcount == 3)
            {
                hi.SetActive(false);
                score.namecheck("L3");
                lcount = 0;
            }
            if (lcount == 0) GetComponent<Renderer>().material = yellowoff;
        }
        if (gameObject.name.Substring(0, 1).Equals("R"))
        {
            if (rcount == 3)
            {
                hi.SetActive(false);
                score.namecheck("R3");
                rcount = 0;
            }
            if (rcount == 0) GetComponent<Renderer>().material = yellowoff;
        }
        if (gameObject.name.Substring(0, 1).Equals("e"))
        {
            if (entercount == 0 || entercount == 3 || entercount == 6) GetComponent<Renderer>().material = yellowoff;
            if (entercount < 3)
            {
                lightstate = 1;
                foreach (GameObject light in lights)
                {
                    light.GetComponent<Renderer>().material.color = Color.blue;
                }
            }
            else if (entercount <= 9)
            {
                statetime += Time.deltaTime;
                //Debug.Log("statecount:" + statetime);
                if (Mathf.Floor(statetime) >= 121)
                {
                    if (entercount <= 6)
                    {
                        entercount = 0;
                        zero();
                    }
                    else if (entercount <= 9)
                    {
                        entercount = 3;
                        zero();
                    }
                }
                
            }
        }
    }
    void zero()
    {
        statetime = 0;
        GetComponent<Renderer>().material = yellowoff;
        Debug.Log("enter:"+entercount);
        if (entercount == 0)
        {
            GetComponent<Renderer>().material = yellowoff;
            lightstate = 1;
            foreach (GameObject light in lights)
            {
                light.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
        if (entercount == 3)
        {
            GetComponent<Renderer>().material = yellowoff;
            score.namecheck("powerup2");
            lightstate = 2;
            foreach (GameObject light in lights)
            {
                light.GetComponent<Renderer>().material.color = Color.green;
            }
        }
        if (entercount == 6)
        {
            GetComponent<Renderer>().material = yellowoff;
            score.namecheck("powerup3");
            lightstate = 3;
            foreach (GameObject light in lights)
            {
                light.GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
        if (entercount == 9)
        {
            GetComponent<Renderer>().material = yellowoff;
            score.namecheck("powerup4");
            lightstate = 4;
            foreach (GameObject light in lights)
            {
                light.GetComponent<Renderer>().material.color = Color.red;
            }
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
                    sound01.PlayOneShot(sound01.clip);
                    score.namecheck("L");
                    Debug.Log(lcount);
                    GetComponent<Renderer>().material = yellowon;
                }
                if (gameObject.name.Substring(0, 1).Equals("R"))
                {
                    rcount++;
                    score.addpoint(700);
                    sound01.PlayOneShot(sound01.clip);
                    score.namecheck("R");
                    Debug.Log(rcount);
                    GetComponent<Renderer>().material = yellowon;
                }
                if (gameObject.name.Substring(0, 1).Equals("e"))//一番上のやつ
                {
                    entercount++;
                    score.addpoint(2000);
                    sound01.PlayOneShot(sound01.clip);
                    score.namecheck("enter");
                    zero();
                    GetComponent<Renderer>().material = yellowon;
                }
                if (gameObject.name.Substring(0, 1).Equals("c"))
                {
                    score.addpoint(1500);
                    sound01.PlayOneShot(sound01.clip);
                    score.namecheck("ca-bu");
                    GetComponent<Renderer>().material = yellowon;
                }
            }
        }


    }
}