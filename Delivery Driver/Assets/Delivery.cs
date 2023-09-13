using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery   : MonoBehaviour
{
    [SerializeField] Color32 colorHasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 colorNoPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float fltDestroyDelay = 0.5f;
    bool blHasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !blHasPackage)
        {
            Debug.Log("Package collected!");
            blHasPackage = true;
            spriteRenderer.color = colorHasPackageColor;
            Destroy(other.gameObject, fltDestroyDelay);
        }

        if (other.tag == "Customer" && blHasPackage)
        {
            Debug.Log("Package delivered!");
            blHasPackage = false;
            spriteRenderer.color = colorNoPackageColor;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("There was a collision!");
    }
}
