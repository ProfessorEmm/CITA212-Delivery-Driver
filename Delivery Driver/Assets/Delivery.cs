using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery   : MonoBehaviour
{
    [SerializeField] float fltDestroyDelay = 0.5f;
    bool blHasPackage;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !blHasPackage)
        {
            Debug.Log("Package collected!");
            blHasPackage = true;
            Destroy(other.gameObject, fltDestroyDelay);
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
