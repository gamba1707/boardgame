using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReStart : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Plunger;
    public GameObject RFliper;
    public GameObject LFliper;
    Vector3 StartPos;
    //Quaternion StartRot;
    // Start is called before the first frame update
    void Start()
    {
        Plunger.SetActive(true);
        RFliper.SetActive(true);
        LFliper.SetActive(true);
        StartPos = new Vector3(14,-21,-7);
        //StartRot = new Quaternion();
        Ball = GameObject.FindGameObjectWithTag ("ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.transform.position.x > 19 
            || Ball.transform.position.x < -19) start();

        if (Ball.transform.position.y > 18
            || Ball.transform.position.y < -36) start();
    }

    void start()
    {
        Ball.transform.position = StartPos;
        Ball = GameObject.FindGameObjectWithTag("ball");     
    }

    void ranking()
    {
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(100);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            //DestroyとInstantiateよりも座標移動の方が処理かるいかも
            //Destroy(Ball);
            //Instantiate(Ball, StartPos, StartRot);


            if (gameover.ball <= 0)
            {

                ranking();
                Plunger.SetActive(false);
                RFliper.SetActive(false);
                LFliper.SetActive(false);
                return;
            }
            else
            {
                start();
            }

gameover.ball -= 1;
            if (gameover.ball == 0)
            {
                CommentText.Comment = "ラストチャンスだ！！";
            }
            else
            {
                CommentText.Comment = "もう一回だ！！";
            }
        }
    }
}
