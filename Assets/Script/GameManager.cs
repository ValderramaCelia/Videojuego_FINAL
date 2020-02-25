using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager current;
    bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool IsGameOver()
    {
        //If there is no current Game Manager, return false
        if (current == null)
            return false;

        //Return the state of the game
        return current.isGameOver;
    }


}
