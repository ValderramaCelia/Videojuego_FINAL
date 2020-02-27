using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pullObject : MonoBehaviour
{
    public List<GameObject> pullObjects;
    public float velocidadBalas;
    void Start()
    {
        pullObjects = new List<GameObject>();
        velocidadBalas = 40;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            GameObject b = Resources.Load("Bala", typeof(GameObject)) as GameObject;
            GameObject bala = Instantiate(b);
            CircleCollider2D coll = bala.GetComponent<CircleCollider2D>();
            Rigidbody2D rgbd = bala.GetComponent<Rigidbody2D>();
            pullObjects.Add(bala);
            bala.transform.position = transform.position;
            if (transform.rotation.eulerAngles.y == 180)
            {
                
                rgbd.velocity = new Vector2(-velocidadBalas, 0);
            }
            else
            {
                rgbd.velocity = new Vector2(velocidadBalas, 0);
            }
            
        }
        /*foreach (GameObject bala in pullObjects){
            if(bala == null)
            {
                pullObjects.Remove(bala);
            }

        } */
        
    }

    

   
}
