using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float n;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        n += Time.deltaTime;
        this.gameObject.transform.Rotate(0, n, 0);
        if (n >= 5) { n = 0; }
    }
}
