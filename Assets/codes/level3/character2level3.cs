using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class character2level3 : MonoBehaviour
{
    //public Transform char2;
    //public Transform cube;
    public Rigidbody2D rb;
    private float speed = 3000;
    public yantriggerlar triggered;
    public yantriggerlar triggered2;
    public yantriggerlar triggered3;
    public yantriggerlar triggered4;
    public karakter2engel1 engel1;
    public karakter2engel2 engel2;
    public karakter2engel3 engel3;
    public ittirici baslatici;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && (triggered.isGrounded == true || triggered2.isGrounded == true || triggered3.isGrounded == true || triggered4.isGrounded == true || engel2.isStarting == true || engel1.isStarting == true || baslatici == true))
        {

            rb.velocity = Vector3.up * speed * Time.deltaTime;
            char2lev3();

        }
        if (Input.GetKeyDown(KeyCode.S) && (triggered.isGrounded == true || triggered2.isGrounded == true || triggered3.isGrounded == true || triggered4.isGrounded == true || engel2.isStarting == true || engel1.isStarting == true || baslatici == true))
        {
            rb.velocity = Vector3.down * speed * Time.deltaTime;
            char2lev3();
        }
        if (Input.GetKeyDown(KeyCode.A) && (triggered.isGrounded == true || triggered2.isGrounded == true || triggered3.isGrounded == true || triggered4.isGrounded == true || engel2.isStarting == true || engel1.isStarting == true || baslatici == true))
        {
            rb.velocity = Vector3.left * speed * Time.deltaTime;
            char2lev3();

        }
        if (Input.GetKeyDown(KeyCode.D) && (triggered.isGrounded == true || triggered2.isGrounded == true || triggered3.isGrounded == true || triggered4.isGrounded == true || engel2.isStarting == true || engel1.isStarting == true || baslatici == true))
        {
            rb.velocity = Vector3.right * speed * Time.deltaTime;
            char2lev3();
        }


    }
    void char2lev3()
    {
        triggered.isGrounded = false;
        triggered2.isGrounded = false;
        triggered3.isGrounded = false;
        triggered4.isGrounded = false;
        engel1.isStarting = false;
        engel2.isStarting = false;
    }
}



