using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //creates a rigidbody vairable that shows up in the component, allows us to reference the player rigidbody
    public Rigidbody rb;
    public float forwardForce = 2000f;  //setting the value to a variable allows us to change the value from the inspector
    public float sidewardForce = 500f;
    public bool dPressed = false;
    public bool aPressed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d")) //check if keys are being pressed in Update method and store their values in booleans to use for fixedUpdate method, this prevents key presses being delayed or missed, more important with single events like jumps.
        {
            dPressed = true;
        } 
        else
        {
            dPressed = false;
        }
        if (Input.GetKey("a"))
        {
            aPressed = true;
        }
        else
        {
            dPressed = false;
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }


    void FixedUpdate()  //Unity likes fixed updates more for doing stuff like colisions, it will look smoother
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //multiplying the force by Time.deltaTime makes the game run the same regardless of the frame rate of the user
        
        if (Input.GetKey("d")) //checks if d is pressed
        {
            rb.AddForce(sidewardForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange); //adds a rightward force (relative to frame rate), the 4th paramenter "ForceMode.VelocityChange" allows the velocity to change without worrying about the mass of the object
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //same thing but in a negative direction (left) for if a is pressed
        }

    }
}
