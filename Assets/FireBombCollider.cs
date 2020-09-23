using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBombCollider : MonoBehaviour
{
    public GameObject fireBombVillage, fireBombBlock, gemVillage, activego;
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
            activego = fireBombBlock;
            if (inTheZone)
            {
                fireBombBlock.SetActive(true);
            }
            else
            {
                fireBombBlock.SetActive(false);
            }
            fireBombVillage.SetActive(false);
            gemVillage.SetActive(false);
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
            activego = fireBombVillage;
            if (inTheZone)
            {
                fireBombVillage.SetActive(true);
                gemVillage.SetActive(true);
            }
            else
            {
                fireBombVillage.SetActive(false);
                gemVillage.SetActive(false);
            }
            fireBombBlock.SetActive(false);
        }
    }
}
