using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{

    public GameObject follow;   // the thing you want the cam to follow
    private Vector3 followPos;  // its position





    // positon of camera is equal to position of player
    // attach rigidbody 2d and lock rotation on z if player rotates

    // Start is called before the first frame update
    void Start()
    {
        followPos = transform.position - follow.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = follow.transform.position + followPos;
    }
}
