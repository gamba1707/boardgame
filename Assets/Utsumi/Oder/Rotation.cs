using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float n;
    public Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0, Time.deltaTime*n, 0);
        if (this.gameObject.transform.position.y <= -5) {
            this.gameObject.transform.position = vec;
        }
    }
}
