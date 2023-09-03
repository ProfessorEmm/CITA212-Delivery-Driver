using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float fltSteerSpeed = 1f;
    [SerializeField] float fltMoveSpeed = 0.01f;
    void Start()
    {

    }

    void Update()
    {
       transform.Rotate(0, 0, fltSteerSpeed);
       transform.Translate(0, fltMoveSpeed, 0);
    }
}
