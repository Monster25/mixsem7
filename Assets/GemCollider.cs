using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollider : MonoBehaviour
{
    bool civilianCol = false;
    public GameObject village;
    private void OnTriggerStay(Collider collider)
    {
        if (collider.name == "Civilian")
            civilianCol = true;
        if (collider.name == "Plane")
        {
            if(civilianCol)
                village.SetActive(false);
            else
                village.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Civilian")
            civilianCol = false;
        if (other.name == "Plane")
        {
            village.SetActive(false);
        }
    }
}