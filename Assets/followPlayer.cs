using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("protagonista");
        
    }

    // Update is called once per frame
    void Update()
    {
        x = player.transform.position.x;
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }

}
