using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel2karakter2 : MonoBehaviour
{
    public bool isStarting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "karakter2")
        {
            isStarting = true;
        }
    }
    
}
