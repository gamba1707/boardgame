using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opmovie : MonoBehaviour
{
    public GameObject verUI;
    public Sprite[] sprites;
    private Image image;
    private AudioSource sound01;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        sound01 = GetComponent<AudioSource>();
        StartCoroutine("movie");
    }

   IEnumerator movie()
    {
        int i = 0;
        while (true)
        {
            image.sprite = sprites[i];
            yield return new WaitForSeconds(0.016f);
            if(i==110&&verUI.activeSelf==false) sound01.PlayOneShot(sound01.clip);
            if (i==140) yield break;
            i++;
        }
    }
}
