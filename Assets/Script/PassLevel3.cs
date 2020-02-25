using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PassLevel3 : MonoBehaviour
{
    int playerLayer;    //The layer the player game object is on
    // Start is called before the first frame update
    void Start()
    {
        //Get the integer representation of the "Player" layer
        playerLayer = LayerMask.NameToLayer("Player");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //If the collision wasn't with the player, exit
        if (collision.gameObject.layer != playerLayer)
            return;
        SceneManager.LoadScene("Nivel 3");

    }

    // Update is called once per frame
    void Update()
    {

    }


}