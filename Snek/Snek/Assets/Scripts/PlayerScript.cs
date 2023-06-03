using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerWidth;
    public float playerHeight;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        playerWidth = transform.localScale.x;
        playerHeight = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        if (Input.GetKeyDown(KeyCode.W) == true) {
            transform.position = new Vector3(transform.position.x, transform.position.y + playerHeight, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.A) == true) {
            transform.position = new Vector3(transform.position.x - playerWidth, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.S) == true) {
            transform.position = new Vector3(transform.position.x, transform.position.y - playerHeight, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D) == true) {
            transform.position = new Vector3(transform.position.x + playerWidth, transform.position.y, transform.position.z);
        }

        //Timer
        timer += Time.deltaTime;
        
    }
}
