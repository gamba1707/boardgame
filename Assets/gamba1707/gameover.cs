using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameover : MonoBehaviour
{
    public TextMeshProUGUI balltext;
    public static int ball;
    // Start is called before the first frame update
    void Start()
    {
        ball=PlayerPrefs.GetInt("ball",3);
    }

    // Update is called once per frame
    void Update()
    {
        balltext.text = ball.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            ball--;
            other.gameObject.transform.position = new Vector3(5.8f, 4.6f, -9.1f);
            score.namecheck("gameover");
            if (ball <= 0)
            {
                naichilab.RankingLoader.Instance.SendScoreAndShowRanking(score.point);
            }
        }
    }
}
