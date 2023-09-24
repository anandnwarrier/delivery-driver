using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Camera's position is going to be the same as the car's position
    [SerializeField] private GameObject thingToFollow;

    void LateUpdate()
    {
        transform.position=thingToFollow.transform.position+ new Vector3(0,0,-10);
    }
}
