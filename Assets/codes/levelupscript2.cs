using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelupscript2 : MonoBehaviour
{
    public bool isDone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "karakter2")
        {
            isDone= true;
            
        }
    }

}
