using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turi : MonoBehaviour
{
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent=transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            parent.transform.rotation = Quaternion.Euler(-106f, 91f, 85f);
            if (gameObject.name.Equals("L_turispot"))
            {
                other.gameObject.transform.position = new Vector3(-4.98f, 6.3f, -5.5f);
                score.namecheck("turi");
            }
            if (gameObject.name.Equals("R_turispot"))
            {
                other.gameObject.transform.position = new Vector3(3.42f, 4.8f, -6.82f);
                score.namecheck("turi");
            }

        }
    }

}
