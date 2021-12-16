using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //Camera should be same as car
    [SerializeField]GameObject ThingToFollow;
    void LateUpdate()
    {
       transform.position = ThingToFollow.transform.position + new Vector3(0,0,-10); 
    }
}
