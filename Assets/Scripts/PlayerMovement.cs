using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalMove = 0f;
    public float verticalMove = 0f;
    public float runSpeed;
    public Joystick joystick;
    // Update is called once per frame
    void FixedUpdate()
    {
             
        if(joystick.Horizontal >= 0.1f)
        {
            horizontalMove = joystick.Horizontal * runSpeed;
            transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime;
        } else if (joystick.Horizontal <= -0.1f)
        {
            horizontalMove = joystick.Horizontal * runSpeed;
            transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime;
        } else
        {
            horizontalMove = 0f;
        }

        if(joystick.Vertical >= 0.1f)
        {
            verticalMove = joystick.Vertical * runSpeed;
            transform.position += new Vector3(0, verticalMove, 0) * Time.deltaTime;
        } else if (joystick.Vertical <= -0.1f)
        {
            verticalMove = joystick.Vertical * runSpeed;
            transform.position += new Vector3(0, verticalMove, 0) * Time.deltaTime;
        }else
        {
            verticalMove = 0f;
        }
            
    }
}
