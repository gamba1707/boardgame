using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaiten : MonoBehaviour
{
    bool comeball;
    Vector3 pos;
    float y, z;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("root");
        pos = transform.position;
        y = gameObject.transform.localEulerAngles.y;
        z = gameObject.transform.localEulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            comeball = true;
        }
    }
    IEnumerator root()
    {
        while (true)
        {
            if (comeball)
            {
                yield return new WaitForSeconds(3f);
                comeball = false;
            }
            else
            {
                yield return new WaitForSeconds(1.5f);
                transform.position = pos;
                transform.rotation = Quaternion.Euler(0, y, z);
            }
            yield return null;
        }
    }
}
