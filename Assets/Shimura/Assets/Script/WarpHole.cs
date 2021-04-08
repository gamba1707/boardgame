using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpHole : MonoBehaviour
{
    GameObject Ball;
    public int GoToScene;
    public int WarpHoleNumber;
    //WarpHoleNumber
    //内海が2
    //小俣が1
    //志村が3
    
    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("ball");

        //ワープ先のシーンを決定させる
        GoToScene = Random.Range(1, 4);
        for (; GoToScene == WarpHoleNumber;)
        {
            //変数がFloat型の場合Random.Range(0, 3)は0以上3以下の値をかえす
            //変数がInt型の場合Random.Range(0, 3)は0以上3未満の値をかえす
            GoToScene = Random.Range(1, 4);
        }
        Debug.Log("ワープ先;"+GoToScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        WarpManager.WarpSwicth = true;
        if (other.gameObject == Ball)
        {
            SceneManager.LoadScene(GoToScene);
            Debug.Log("WarpSwicth:"+WarpManager.WarpSwicth);
        }
        
    }
}
