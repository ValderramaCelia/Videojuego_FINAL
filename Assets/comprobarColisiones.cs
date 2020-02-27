using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobarColisiones : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D other)
    {
       
       if (other.gameObject.tag == "enemigo" || other.gameObject.tag == "pared")
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "enemigo" || other.gameObject.tag == "pared")
        {
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "enemigo")
        {
            Destroy(other.gameObject);
        }
    }
}
