using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //variables
    public float speed = .1f;
    private Rigidbody rb;
    //private CharacterController cc;
    private Vector3 movement;

    private void Start()
    {
        //initialize variables with components
        rb = GetComponent<Rigidbody>();
        //cc = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        //get movement input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //create a vector from input
        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //modifications to the vector based on other logic
        

        //Apply movement
        rb.MovePosition(rb.position + movement * speed);
        //cc.Move(movement * speed);
        //rb.AddForce(movement * speed);
    }
}
