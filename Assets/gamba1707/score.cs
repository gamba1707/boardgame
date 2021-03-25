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
            point += int.Parse(gameObject.name.Substring(0, 4));
            Debug.Log("point:" + point);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
            point += int.Parse(gameObject.name.Substring(0, 4));
        namecheck(gameObject.name);
            Debug.Log("point:" + point);
    }

    void namecheck(string name)
    {
        switch (name)
        {
            case "0500_kaiten":
                messagetext.text = "回転フラグ\n500点";
                break;
        }
    }
}
