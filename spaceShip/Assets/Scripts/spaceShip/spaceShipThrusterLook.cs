using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipThrusterLook : MonoBehaviour
{


    
    public Transform lookAt;


    // Start is called before the first frame update
    void Start()
    {

        print("look at " + lookAt.position);
        print("transform "+transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = lookAt.position - transform.position;
        
        
    }
}
