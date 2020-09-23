using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCollision2 : MonoBehaviour
{
    public GameObject go1;
    private void OnTriggerStay(Collider collider)
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
