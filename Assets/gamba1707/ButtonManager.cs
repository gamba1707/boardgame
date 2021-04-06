using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void OnStartScene()
    {
        SceneManager.LoadScene("Start");
    }
    public void OnUtsumiScene()
    {
        SceneManager.LoadScene("UtsumiScene");
    }
    public void OngambaScene()
    {
        SceneManager.LoadScene("gambaScene");
    }
    public void OnShimuraScene()
    {
        SceneManager.LoadScene("Stage1");
    }
}
