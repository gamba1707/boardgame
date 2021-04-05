using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restert : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            other.transform.position = new Vector3(5.48f, 9.25f, -8.33f);
        }
    }
}
