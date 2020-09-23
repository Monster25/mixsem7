using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCollision : MonoBehaviour
{
    bool civilianCol = false;
    public GameObject go1;
    private void OnTriggerStay(Collider collider)
    {
        if (collider.name == "Civilian")
            civilianCol = true;
        if (collider.name == "Plane")
        {
            if(civilianCol)
                go1.SetActive(false);
            else
                go1.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Civilian")
            civilianCol = false;
        if (other.name == "Plane")
        {
            go1.SetActive(false);
        }
    }
}