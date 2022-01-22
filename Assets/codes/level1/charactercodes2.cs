using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercodes2 : MonoBehaviour
{
    //public Transform char2;
    //public Transform cube;
    public Rigidbody2D rb;
    private float speed = 3000;
    public yantriggerlar triggered;
    public yantriggerlar triggered2;
    public yantriggerlar triggered3;
    public yantriggerlar triggered4;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && (triggered.isGrounded == true || triggered2.isGrounded ==true || triggered3.isGrounded ==true ||triggered4.isGrounded ==true))
        {
          
            rb.velocity = Vector3.up * speed * Time.deltaTime;
            char2codes();


        }
        if (Input.GetKeyDown(KeyCode.S) && (triggered.isGrounded == true || triggered2.isGrounded == true || triggered3.isGrounded == true || triggered4.isGrounded == true))
        {
            rb.velocity = Vector3.down * speed * Time.deltaTime;
            char2codes();
        }
        if (Input.GetKeyDown(KeyCode.A) && (triggered.isGrounded == true || triggered2.isGrounded == true || triggered3.isGrounded == true || triggered4.isGrounded == true))
        {
            rb.velocity = Vector3.left * speed * Time.deltaTime;
            char2codes();
            
        }
        if (Input.GetKeyDown(KeyCode.D)&& (triggered.isGrounded == true || triggered2.isGrounded == true || triggered3.isGrounded == true || triggered4.isGrounded == true))
        {
            rb.velocity = Vector3.right * speed * Time.deltaTime;
            char2codes();
        }
        
    
    }
    void char2codes()
    {
        triggered.isGrounded = false;
        triggered2.isGrounded = false;
        triggered3.isGrounded = false;
        triggered4.isGrounded = false;
    }


}
