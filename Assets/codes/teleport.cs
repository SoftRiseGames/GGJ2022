using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform transloc;
    public GameObject char2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "karakter2")
        {
            char2.gameObject.transform.position = transloc.transform.position;
        }
    }
}
