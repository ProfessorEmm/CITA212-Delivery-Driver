using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // the camera's position should be the same as the car's position


    [SerializeField] GameObject goThingToFollow;

    // use LateUpdate so that the camera is moved after the car has moved. this avoids 
    // execution order problems
    void LateUpdate()
    {
        // camera offset to be above car
        transform.position = goThingToFollow.transform.position + new Vector3(0, 0, -10); 
    }
}
