using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivillianCollider : MonoBehaviour
{
    public GameObject go1, go2, go3, activego;
    bool inTheZone = false;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.name == "Plane")
        {
            inTheZone = true;
            activego.SetActive(true);
        }
        else if (collider.name == "Civilian")
        {
            activego = go2;
            if (inTheZone)
            {
                go2.SetActive(true);
            }
            else
            {
                go2.SetActive(false);
            }
            go1.SetActive(false);
            go3.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Plane")
        {
            inTheZone = false;
            activego.SetActive(false);
        }
        else if (other.name == "Civilian")
        {
            activego = go1;
            if (inTheZone)
            {
                go1.SetActive(true);
                go3.SetActive(true);
            }
            else
            {
                go1.SetActive(false);
                go3.SetActive(false);
            }
            go2.SetActive(false);
        }
    }
}
