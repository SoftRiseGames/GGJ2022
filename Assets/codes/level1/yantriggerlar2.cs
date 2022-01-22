using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yantriggerlar2 : MonoBehaviour
{
    public bool isGrounded2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "karakter")
        {
            isGrounded2 = true;
            
        }
    }
   
    
}
