using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1startingtrigger : MonoBehaviour
{
    public bool isStarting;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "karakter")
        {
            
            isStarting = true;
            gameObject.SetActive(false);
            
        }
    }
    
}
