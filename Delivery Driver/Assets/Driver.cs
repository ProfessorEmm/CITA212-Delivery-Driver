using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Windows;

public class Driver : MonoBehaviour
{
    [SerializeField] float fltSteerSpeed = 40f;
    [SerializeField] float fltMoveSpeed = 5f;
    void Start()
    {

    }

    void Update()
    {
       float fltSteerAmount = UnityEngine.Input.GetAxis("Horizontal") * fltSteerSpeed * Time.deltaTime;
       float fltMoveAmount = UnityEngine.Input.GetAxis("Vertical") * fltMoveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -fltSteerAmount);
       transform.Translate(0, fltMoveAmount, 0);
    }
}
