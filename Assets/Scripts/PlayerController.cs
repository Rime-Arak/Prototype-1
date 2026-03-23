//using System.Numerics;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Take player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the vehicle forward based on input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotate the vehicle based on input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        //Extra: increase speed if shift key is pressed
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 35.0f;
        }
        else
        {
            speed = 15.0f;
        }
    }
}
