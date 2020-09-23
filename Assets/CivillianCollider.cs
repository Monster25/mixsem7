using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivillianCollider : MonoBehaviour
{
    public GameObject go1, go2, go3;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.name == "Plane")
        {
            go1.SetActive(true);
        }
        else
        {
            go2.SetActive(true);
            go1.SetActive(false);
            go3.SetActive(false);
        }
         
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Plane")
        {
            go1.SetActive(false);
        }
        else
        {
            go2.SetActive(false);
            go1.SetActive(true);
            go3.SetActive(true);
        }
    }
}
