using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer1 : MonoBehaviour
{
    public float movementSpeed;
    protected Joystick joystick;

    //private void FixedUpdate()
    //{
    //    float v = Input.GetAxisRaw("Vertical");



    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
    //    }


    //}

     void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        //GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

    }

     void Update()
    {
        var rigidbody =GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(joystick.Horizontal*0,joystick.Vertical*200f);

        
    }

}
