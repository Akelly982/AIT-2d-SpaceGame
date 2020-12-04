using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class animAccesor : MonoBehaviour
{

    Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnim.SetFloat("focal_x", Input.GetAxis("Horizontal")); //focal_x,y is my floats in my animatior for blending animations 
        myAnim.SetFloat("focal_y", Input.GetAxis("Vertical"));   // focal_x,y is relative to my hori / verti because all are 0 - 1

    }
}
