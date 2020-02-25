﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacteController : MonoBehaviour
{
    public float speed = 2f;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        void FixedUpdate()
        {
            float h = Input.GetAxis("Horizontal");

            rb2d.AddForce(Vector2.right * speed * h);

        }
    }
}
