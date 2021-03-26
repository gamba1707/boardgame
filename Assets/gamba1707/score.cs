using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int point;
    TextMeshProUGUI scoretext;
    static Text messagetext;
    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.tag.Equals("scoretext")) scoretext = gameObject.GetComponent<TextMeshProUGUI>();
        if (this.gameObject.tag.Equals("messagetext")) messagetext = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag.Equals("scoretext"))
        {
            scoretext.text = point.ToString();
        }
    }
    public static void addpoint(int x)
    {
        point += x;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            if(gameObject.name.Equals("0500")&& gameObject.name.Equals("1500")) point += int.Parse(gameObject.name.Substring(0, 4))*re_side.lightstate;
            else point += int.Parse(gameObject.name.Substring(0, 4));
            namecheck(gameObject.name);
            Debug.Log("point:" + point);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            point += int.Parse(gameObject.name.Substring(0, 4));
            namecheck(gameObject.name);
            Debug.Log("point:" + point);
        }
    }

    public static void namecheck(string name)
    {
        switch (name)
        {
            case "0500_kaiten":
                messagetext.text = "回転フラグ\n500点";
                break;
            case "0500":
                messagetext.text = "ジェットバンパー\n"+500 * re_side.lightstate + "点";
                break;
            case "1500":
                messagetext.text = "ジェットバンパー\n" + 1500 * re_side.lightstate + "点";
                break;
            case "L":
                messagetext.text = "ハザードターゲット\n700点";
                break;
            case "R":
                messagetext.text = "ハザードターゲット\n700点";
                break;
            case "L3":
                messagetext.text = "左下ゲート開放！";
                break;
            case "R3":
                messagetext.text = "右下ゲート開放！";
                break;
            case "enter":
                messagetext.text = "再突入レーン\n2000点";
                break;
            case "ca-bu":
                messagetext.text = "カーブレーン通過\n1500点";
                break;
            case "0500_リバウンド":
                messagetext.text = "リバウンド\n500点";
                break;
            case "powerup2":
                messagetext.text = "パワーアップ第2段階";
                break;
            case "powerup3":
                messagetext.text = "パワーアップ第3段階";
                break;
            case "powerup4":
                messagetext.text = "パワーアップ第4段階！\nおめでとう！";
                break;
            case "bag":
                messagetext.text = "バグです！\n初期化...";
                break;
            case "gameover":
                messagetext.text = "クラッシュ！";
                break;
        }
    }
}
