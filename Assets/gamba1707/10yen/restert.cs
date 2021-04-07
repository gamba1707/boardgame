using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restert : MonoBehaviour
{
    private AudioSource kanseisound01;
    private void Start()
    {
        kanseisound01 = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            if (gameObject.name.Equals("clear"))
            {
                score.addpoint(1000);
                kanseisound01.PlayOneShot(kanseisound01.clip);
            }
            other.transform.position = new Vector3(5.48f, 9.25f, -8.33f);
        }
    }
}
