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
        Comment = "�X�y�[�X�L�[�Ŕ��ˁI";
        Text.text =Comment;
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = Comment;
    }
}
