using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Windows;

public class Driver : MonoBehaviour
{
    [SerializeField] float fltSteerSpeed = 1f;
    [SerializeField] float fltMoveSpeed = 0.01f;
    void Start()
    {

    }

    void Update()
    {
       float fltSteerAmount = UnityEngine.Input.GetAxis("Horizontal") * fltSteerSpeed;
       float fltMoveAmount = UnityEngine.Input.GetAxis("Vertical") * fltMoveSpeed;
        transform.Rotate(0, 0, -fltSteerAmount);
       transform.Translate(0, fltMoveAmount, 0);
    }
}
