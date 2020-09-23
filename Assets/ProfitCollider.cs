using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfitCollider : MonoBehaviour
{
    public GameObject mine;
    private void OnTriggerStay(Collider collider)
    {
        if (collider.name == "Plane")
        {
            mine.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Plane")
        {
            mine.SetActive(false);
        }
    }
}
