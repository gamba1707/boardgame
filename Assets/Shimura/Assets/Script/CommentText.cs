using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CommentText : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public static string Comment;
    // Start is called before the first frame update
    void Start()
    {
        Comment = "スペースキーで発射！";
        Text.text =Comment;
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = Comment;
    }
}
