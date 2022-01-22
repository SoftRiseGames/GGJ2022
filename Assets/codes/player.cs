using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 10;
    public bool isCollided;
    public player otherplayer;
    
    public void Awake()
    {
        isCollided = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (isCollided && otherplayer.isCollided)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                otherplayer.isCollided = false;
                isCollided = false;
                rb.velocity = Vector3.up * speed;
                otherplayer.rb.velocity = Vector3.up * speed;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                otherplayer.isCollided = false;
                isCollided = false;
                rb.velocity = Vector3.down * speed;
                otherplayer.rb.velocity = Vector3.down * speed;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                otherplayer.isCollided = false;
                isCollided = false;
                rb.velocity = Vector3.left * speed;
                otherplayer.rb.velocity = Vector3.left * speed;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                otherplayer.isCollided = false;
                isCollided = false;
                rb.velocity = Vector3.right * speed;
                otherplayer.rb.velocity = Vector3.right * speed;


            }
        }
    }  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isCollided = true;
    }
    



}