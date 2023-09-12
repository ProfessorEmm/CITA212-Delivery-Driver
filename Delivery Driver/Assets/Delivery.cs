using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery   : MonoBehaviour
{
    bool blHasPackage;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Package collected!");
            blHasPackage = true;
        }

        if (other.tag == "Customer" && blHasPackage)
        {
            Debug.Log("Package delivered!");
            blHasPackage = false;

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("There was a collision!");
    }
}
