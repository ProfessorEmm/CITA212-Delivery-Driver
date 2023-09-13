using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Windows;

public class Driver : MonoBehaviour
{
    [SerializeField] float fltSteerSpeed = 40f;
    [SerializeField] float fltMoveSpeed = 10f;
    [SerializeField] float fltSlowSpeed = 5f;
    [SerializeField] float fltBoostSpeed = 20f;
    
    void Update()
    {
       float fltSteerAmount = UnityEngine.Input.GetAxis("Horizontal") * fltSteerSpeed * Time.deltaTime;
       float fltMoveAmount = UnityEngine.Input.GetAxis("Vertical") * fltMoveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -fltSteerAmount);
       transform.Translate(0, fltMoveAmount, 0);
    }

    // bumping into the boost object
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            fltMoveSpeed = fltBoostSpeed;
        }
    }

    // bumping into any object
    void OnCollisionEnter2D(Collision2D other)
    {
            fltMoveSpeed = fltSlowSpeed;
    }
}
