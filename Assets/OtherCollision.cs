using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCollision : MonoBehaviour
{
    public GameObject go1;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Plane")
        {
            go1.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Plane")
        {
            go1.SetActive(false);
        }
    }
}