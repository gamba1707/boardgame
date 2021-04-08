using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover_shimura : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover.ball == 0) ranking();
    }

    void ranking()
    {
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(100);       
    }
}
