using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class gunShoot : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        ////this one works
        //// made by Stirling
        
        //Vector3 myMouse = Input.mousePosition;
        
        //myMouse = Camera.main.ScreenToWorldPoint(myMouse);  // get position of mouse from camera   // this works because my "gun" is always centered 
        //myMouse.z = 0; // dont translate in thrid dimension

        //print(myMouse.ToString());
        //transform.right = myMouse - transform.position;





        // version 1
        //Vector3 myMouse = new Vector3(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"), 0);
        //Vector3 myMouse = Input.mousePosition;
        //Vector3 zeroVector = new Vector3(0, 0, 0);

        //// version 2
        //Vector3 myMouse = new Vector3(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"), 0);
        //Vector3 zeroVector = new Vector3(0, 0, 0);

        //print(myMouse.ToString());
        //if (!myMouse.Equals(zeroVector))
        //{
        //    transform.right = myMouse - transform.position;
        //}





        // version 3
        //print(Input.mousePosition);
        //transform.right = Input.mousePosition - transform.position;





    }
}
