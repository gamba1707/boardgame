using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public static int point;
    TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.tag.Equals("scoretext")) scoretext = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag.Equals("scoretext"))
        {
            scoretext.text = point.ToString();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            point += int.Parse(gameObject.name.Substring(0, 4));
            Debug.Log("point:" + point);
        }
    }
}
