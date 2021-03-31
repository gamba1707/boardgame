using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score2 : MonoBehaviour
{
    public AudioClip Audio;
    AudioSource Source;
    // Start is called before the first frame update
    void Start()
    {
        Source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            score.point += int.Parse(this.gameObject.name.Substring(0, 4));
            Source.PlayOneShot(Audio);
        }
    }
}
