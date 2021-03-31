using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScore : MonoBehaviour
{
    [SerializeField]public GameObject[] Digit0 = new GameObject[10];
    [SerializeField] public GameObject[] Digit1 = new GameObject[10];
    [SerializeField] public GameObject[] Digit2 = new GameObject[10];
    [SerializeField] public GameObject[] Digit3 = new GameObject[10];
    [SerializeField] public GameObject[] Digit4 = new GameObject[10];
    [SerializeField] public GameObject[] Digit5 = new GameObject[10];
    [SerializeField] public GameObject[] Digit6 = new GameObject[10];
    [SerializeField] public GameObject[] Digit7 = new GameObject[10];
    [SerializeField] public GameObject[] Digit8 = new GameObject[10];
    
    public GameObject Real0;
    public GameObject Real1;
    public GameObject Real2;
    public GameObject Real3;
    public GameObject Real4;
    public GameObject Real5;
    public GameObject Real6;
    public GameObject Real7;
    public GameObject Real8;
    
    [SerializeField,Range(0,100000000)]public int MYscore;
    public GameObject Extxt;
    private int a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MYscore <= 0) { Extxt.SetActive(true); } else { Extxt.SetActive(false); }
        MYscore = score.point;
        Real0 = Digit0[MYscore % 10];
        a = MYscore % 10;
        Real1 = Digit1[(MYscore % 100-a)/10];
        a = (MYscore % 100 - a);
        Real2 = Digit2[(MYscore % 1000-a)/100];
        a = MYscore % 1000 - a;
        Real3 = Digit3[(MYscore % 10000-a) / 1000];
        a = MYscore % 10000 - a;
        Real4 = Digit4[(MYscore % 100000-a) / 10000];
        a = MYscore % 100000 - a;
        Real5 = Digit5[(MYscore % 1000000 - a) / 100000];
        a = MYscore % 1000000 - a;
        Real6 = Digit6[(MYscore % 10000000 - a) / 1000000];
        a = MYscore % 10000000 - a;
        Real7 = Digit7[(MYscore % 100000000 - a) / 10000000];
        a = MYscore % 100000000 - a;
        Real8 = Digit8[(MYscore % 1000000000 - a) / 100000000];
        a = MYscore % 1000000000 - a;
        for (int i = 0; i < 10; i++)
        {
            if (Digit0[i]== Real0) { Digit0[i].SetActive(true); } else { Digit0[i].SetActive(false); }
            if (Digit1[i] == Real1) { Digit1[i].SetActive(true); } else { Digit1[i].SetActive(false); }
            if (Digit2[i] == Real2) { Digit2[i].SetActive(true); } else { Digit2[i].SetActive(false); }
            if (Digit3[i] == Real3) { Digit3[i].SetActive(true); } else { Digit3[i].SetActive(false); }
            if (Digit4[i] == Real4) { Digit4[i].SetActive(true); } else { Digit4[i].SetActive(false); }
            if (Digit5[i] == Real5) { Digit5[i].SetActive(true); } else { Digit5[i].SetActive(false); }
            if (Digit6[i] == Real6) { Digit6[i].SetActive(true); } else { Digit6[i].SetActive(false); }
            if (Digit7[i] == Real7) { Digit7[i].SetActive(true); } else { Digit7[i].SetActive(false); }
            if (Digit8[i] == Real8) { Digit8[i].SetActive(true); } else { Digit8[i].SetActive(false); }
        }
    }
}
