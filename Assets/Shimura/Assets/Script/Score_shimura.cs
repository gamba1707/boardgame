using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_shimura : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score\n" + score.point.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score\n" + score.point.ToString();
    }
}
