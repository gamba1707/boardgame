using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpHoleMove1 : MonoBehaviour
{
    public float XDistance;
    public float YDistance;
    public float ZDistance;
    public float Speed;
    public float Timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer = Time.time;
        Vector3 pos = this.transform.position;
        pos.x = pos.x + XDistance * Mathf.Cos(Timer * Speed);
        pos.y = pos.y + YDistance * Mathf.Cos(Timer * Speed);
        pos.z = pos.z + ZDistance * Mathf.Cos(Timer * Speed);
        this.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
