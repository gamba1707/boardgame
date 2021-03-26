using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public GameObject ball;
    public Vector3 pos1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            int a = Random.Range(1, 3);
            if (a == 1)
            {
                ball.transform.position = pos1;
            }
            else if (a == 2)
            {
                SceneManager.LoadScene("MainScene");
            }
            else { SceneManager.LoadScene("MainScene"); }
        }
    }
}
