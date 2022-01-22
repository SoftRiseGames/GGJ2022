using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2startingscript : MonoBehaviour
{
    
    
        public bool isStarting;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "karakter" || collision.gameObject.tag =="karakter2")
        {
            isStarting = true;
        }
    }

}


