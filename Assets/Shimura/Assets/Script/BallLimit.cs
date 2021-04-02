using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallLimit : MonoBehaviour
{
    public TextMeshProUGUI BallText;
    // Start is called before the first frame update
    void Start()
    {
        if (gameover.ball == 0) gameover.ball = 3;
        BallText.text = "Limit\n" + gameover.ball.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        BallText.text = "Limit\n" + gameover.ball.ToString();
    }
}
