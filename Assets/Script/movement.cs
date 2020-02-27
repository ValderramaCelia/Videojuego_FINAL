using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Vector3 delante = new Vector3(1f, 0f, 0f);
    Vector3 atras = new Vector3(-1f, 0f, 0f);
    Vector3 arriba = new Vector3(0f, 1f, 0f);
    Vector3 abajo = new Vector3(0f, -1f, 0f);
    Vector3 delante2D = new Vector2(1f, 0f);
    Vector3 atras2D = new Vector2(-1f, 0f);
    Vector3 arriba2D = new Vector2(0f, 1f);
    Vector3 abajo2D = new Vector2(0f, -1f);
    public float force = 2f;

    public Rigidbody2D rb2d;
    public bool vNegativa = true;
    public bool vCero = true;
    public float maxSpeedX = 4;
    public float maxSpeedY = 17;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        vNegativa = true;
        vCero = true;

    }

    // Update is called once per frame


    void Update()
    {
        Debug.Log("Text: " + rb2d.velocity.y);

        if (rb2d.velocity.y < 0)
        {
            vNegativa = true;
        }
        if (rb2d.velocity.y == 0)
        {
            vCero = true;
        }
        if (Input.GetKey("d"))
        {
            rb2d.AddForce(delante2D * force) ;
            transform.rotation = Quaternion.Euler(0f,0f,0f);
            
        }
        if (Input.GetKey("a"))
        {
            rb2d.AddForce(atras2D * force);
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (Input.GetKey("w"))
        {   if (vCero && vNegativa)
            {
                vNegativa = false;
                vCero = false;
                
                rb2d.AddForce(arriba2D * (force *40.8f));
            }
        }
        if (rb2d.velocity.x > maxSpeedX)
        {
            rb2d.velocity = new Vector2(maxSpeedX,rb2d.velocity.y) ;
        }
        if (rb2d.velocity.y > maxSpeedY)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x,maxSpeedY);
        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "llamas" )
        {
            //Destroy(gameObject);
        }
    }

}
