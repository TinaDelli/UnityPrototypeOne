using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    //setting the access modifier to public allows our variable to be seen and editable in Unity, so setting to private hides these
    private float speed = 10.0f; 
    private float turnSpeed = 25.0f;
    private float horizontalInput; //input we'll be tracking for our horizontal - left and right
    private float forwardInput; //input we'll be tracking for our vertical - up or down

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal"); //Assign our horizontalInput variable to Unity's Input Manager
        forwardInput = Input.GetAxis("Vertical"); //Assign our forwardInput variable to Unity's Input Manager
        
        //This will make the vehicle move forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //this is easier to read shorthand for transform.Translate(0,0,1), We are multiplying by a second and moving {speed} times per second
        //This will make the vehicle turn
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
