using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class charactercodeslevel2 : MonoBehaviour
{
    private float speed = 3000;
    public Rigidbody2D rb;
    public yantriggerlar2 triggered;
    public yantriggerlar2 triggered2;
    public yantriggerlar2 triggered3;
    public yantriggerlar2 triggered4;
    private int hamle = 4, level;
    public Button trysys;
    public levelupscript leveling;
    public level2startingscript start;


    private int uppingsys;





    void Start()
    {

        Time.timeScale = 1;
        trysys.gameObject.SetActive(false);
        uppingsys = leveling.upping;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && (triggered.isGrounded2 == true || triggered2.isGrounded2 == true || triggered3.isGrounded2 == true || triggered4.isGrounded2 == true  || start.isStarting==true))
        {
            rb.velocity = Vector3.up * speed * Time.deltaTime;
            charlev2();
        }
        if (Input.GetKeyDown(KeyCode.S) && (triggered.isGrounded2 == true || triggered2.isGrounded2 == true || triggered3.isGrounded2 == true || triggered4.isGrounded2 == true || start.isStarting==true))
        {
            rb.velocity = Vector3.down * speed * Time.deltaTime;
            charlev2();



        }
        if (Input.GetKeyDown(KeyCode.A) && (triggered.isGrounded2 == true || triggered2.isGrounded2 == true || triggered3.isGrounded2 == true || triggered4.isGrounded2 == true || start.isStarting==true))
        {
            rb.velocity = Vector3.left * speed * Time.deltaTime;
            charlev2();
        }
        if (Input.GetKeyDown(KeyCode.D) && (triggered.isGrounded2 == true || triggered2.isGrounded2 == true || triggered3.isGrounded2 == true || triggered4.isGrounded2 == true || start.isStarting==true))
        {
            rb.velocity = Vector3.right * speed * Time.deltaTime;
            charlev2();
        }

        if (hamle < 0)
        {
            Time.timeScale = 0;
            trysys.gameObject.SetActive(true);
        }


    }
    void charlev2()
    {
        hamle = hamle - 1;

        triggered.isGrounded2 = false;
        triggered2.isGrounded2 = false;
        triggered3.isGrounded2 = false;
        triggered4.isGrounded2 = false;


        start.isStarting = false;
    }
}

