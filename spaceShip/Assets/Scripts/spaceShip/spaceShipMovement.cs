using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipMovement : MonoBehaviour
{

    // buttons
    //   f   inertiaON - bool 
    //   q   flipDirection - bool


    Rigidbody2D rb2d;
    public GameObject[] flipDirectionArray;
    public GameObject gunObj;
    public GameObject body;
    public GameObject thruster1;
    public GameObject thruster2;
    public GameObject thrusterFire1, thrusterFire2;
    public bool flipDirection;
    public float speed;
    public bool inertiaOn;
    float dragStrength;
    float dragBase;



    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        dragBase = 0;
        dragStrength = 2;
        inertiaOn = false;
        flipDirection = false;
    }

    // Update is called once per frame
    void Update()
    {


        // movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);


        // if their should be thruster fire visable or not
        if (moveHorizontal != 0 || moveVertical != 0) {
            thrusterFire1.SetActive(true);
            thrusterFire2.SetActive(true);
        }
        else {
            thrusterFire1.SetActive(false);
            thrusterFire2.SetActive(false);
        }


        // inertia 
        if (Input.GetKeyDown(KeyCode.F))
        {
            inertiaOn = !inertiaOn;  // creates a bool that turns on/ off with button press
        }
        if (inertiaOn)
        {
            rb2d.drag = dragStrength;
        }
        else
        {
            rb2d.drag = dragBase;
        }
        

        // flip direction
        if (Input.GetKeyDown(KeyCode.Q))
        {
            flipDirection = !flipDirection;
        }
        if (flipDirection)
        {
            // flip basic sprites
            bool currentDirection;
            currentDirection = body.GetComponent<SpriteRenderer>().flipX;
            body.GetComponent<SpriteRenderer>().flipX = !currentDirection;
            thruster1.GetComponent<SpriteRenderer>().flipX = !currentDirection;
            thruster2.GetComponent<SpriteRenderer>().flipX = !currentDirection;


            // flip gun requires translation aswell
            gunObj.GetComponent<SpriteRenderer>().flipX = !gunObj.GetComponent<SpriteRenderer>().flipX;
            if (gunObj.GetComponent<SpriteRenderer>().flipX)
            { 
                gunObj.transform.localPosition = new Vector3(0.533f, 0.31f, 0.0f);
            }
            else
            {
                gunObj.transform.localPosition = new Vector3(-0.533f, 0.31f, 0.0f);
               
            }




            flipDirection = false;
        }



        
        



        
    }
}
