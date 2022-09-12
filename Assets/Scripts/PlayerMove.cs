using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    //public float myScore = 10.5f;
    //int myHealth = 5;
    //string myName = "Bob";
    //bool gameOver = false;

    //Vector3 newRotation = new Vector3(90, 0, 0);

    //char myKey = 'w';

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(myScore);
        //Debug.Log("Hello world!");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("This is running always.");
        //Vector3 currentPosition = transform.position;

        //Vector3 mousePos = Input.mousePosition;
        //currentPosition = Camera.main.ScreenToWorldPoint(mousePos);
        //currentPosition.z = 0;
        //transform.position = currentPosition;
        //Debug.Log(currentPosition);

        Vector3 currentPosition = transform.position;

        if (Input.GetKey("up"))
        {
            currentPosition.y += speed;
        }
        if (Input.GetKey("s"))
        {
            currentPosition.y -= speed;
        }
        if (Input.GetKey("a"))
        {
            currentPosition.x -= speed;
        }
        if (Input.GetKey("d"))
        {
            currentPosition.x += speed;
        }

        transform.position = currentPosition;

    }
}
