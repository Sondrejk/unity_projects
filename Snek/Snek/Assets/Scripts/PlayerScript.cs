using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerWidth;
    public float playerHeight;
    public float timer;
    public string lastKeyPressed;
    // Start is called before the first frame update
    void Start()
    {
        playerWidth = transform.localScale.x;
        playerHeight = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Storing last key pressed
        if (Input.GetKeyDown(KeyCode.W) == true){
            lastKeyPressed = "W";
        }
        if (Input.GetKeyDown(KeyCode.A) == true){
            lastKeyPressed = "A";
        }
        if (Input.GetKeyDown(KeyCode.S) == true){
            lastKeyPressed = "S";
        }
        if (Input.GetKeyDown(KeyCode.D) == true){
            lastKeyPressed = "D";
        }

        // Executing movement based on timer and last key pressed
        if (timer >= 0.15) {
            timer = 0;
            if (lastKeyPressed == "W"){
                transform.position = new Vector3(transform.position.x, transform.position.y + playerHeight, transform.position.z);
            }
            if (lastKeyPressed == "A"){
                transform.position = new Vector3(transform.position.x - playerWidth, transform.position.y, transform.position.z);
            }
            if (lastKeyPressed == "S"){
                transform.position = new Vector3(transform.position.x, transform.position.y - playerHeight, transform.position.z);
            }
            if (lastKeyPressed == "D"){
                transform.position = new Vector3(transform.position.x + playerWidth, transform.position.y, transform.position.z);
            }
        }

        //Timer
        timer += Time.deltaTime;
        
    }
}
