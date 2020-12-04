using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spaceUI : MonoBehaviour
{
    public Text posY, posX, survivorText, playerAreaText;
    public Button playAreaButton;
    double DubX, DubY;
    int count, randomNum;
    public GameObject player, respawn1pos, respawn2pos, respawn3pos, controls;
    bool showHud = false;
    Rigidbody2D rb2d;



    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        playAreaButton.gameObject.SetActive(false);
        playerAreaText.gameObject.SetActive(false);
        rb2d = GetComponent<Rigidbody2D>();
    }





    // Update is called once per frame
    void Update()
    {

        // player location
        DubY = System.Math.Round(gameObject.transform.position.y, 2); // 2 = num of decimal places
        DubX = System.Math.Round(gameObject.transform.position.x, 2);
        posY.text = "Pos Y: " + DubY;
        posX.text = "Pos X: " + DubX;




        // show controls
        if (Input.GetKeyDown(KeyCode.C))
        {
            showHud = !showHud;
        }
        if (showHud)
        {
            controls.gameObject.SetActive(true);
        }
        else controls.gameObject.SetActive(false);


    }




    // detecting found triggers
    private void OnTriggerEnter2D(Collider2D foundTrigger)   // Collider2d of gameObject collided with
    {

        if (foundTrigger.gameObject.CompareTag("pickUp"))
        {  // if tag == pickUp
            foundTrigger.gameObject.SetActive(false); // other gameObject do thing.
            count++;
            print("Count =" + count.ToString());
            survivorText.text = "Save lost spacers: " + count + "/5";
        }

        if (foundTrigger.gameObject.CompareTag("playArea"))
        {
            playAreaButton.gameObject.SetActive(false);
            playerAreaText.gameObject.SetActive(false);
        }
    }


    // detecting left triggers
    private void OnTriggerExit2D(Collider2D leftTrigger)
    {
        if (leftTrigger.gameObject.CompareTag("playArea"))
        {
            playAreaButton.gameObject.SetActive(true);
            playerAreaText.gameObject.SetActive(true);
        }
    }



    // left playArea button fuction call 
    public void respawnPlayer()
    {
        randomNum = Random.Range(1, 3);

        // stop player current speed / velocity before respawn
        player.GetComponent<Rigidbody2D>().angularVelocity.Equals(Vector3.zero);     
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;


        // where do I respawn
        if (randomNum == 1)
        {
            player.transform.position = (respawn1pos.transform.position);
        }
        if (randomNum == 2)
        {
            player.transform.position = (respawn2pos.transform.position);
        }
        if (randomNum == 3)
        {
            player.transform.position = (respawn3pos.transform.position);
        }
        else
        {
            print("Error");
        }
        

    }

}
