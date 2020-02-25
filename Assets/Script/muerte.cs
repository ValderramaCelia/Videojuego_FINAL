using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerte : MonoBehaviour
{




     void Update()
    {
         void OncollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Trampa")
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    }

   


}
