using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detzanki : MonoBehaviour
{
    public int zanki;
    public Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            gameover.ball--;
            if (gameover.ball <= 0)
            {
                naichilab.RankingLoader.Instance.SendScoreAndShowRanking(score.point);
            }
            else
            {

                collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                collision.transform.localPosition = vec;
            }

        }
        
    }
}
