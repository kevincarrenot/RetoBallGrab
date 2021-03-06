﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    
    Vector3 posicionInicial;
    Rigidbody2D rb;
    public float speed;
    public Score puntos;
    public SoundSystem sonido;
    //public GameObject balonM;

    void Start()
    {
        posicionInicial = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    public void Reset()
    {
        transform.position = posicionInicial;
    }

    void Update()
    {
       rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed,0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.position = new Vector3(Random.Range(-5f, 7f), 8, 0);
        sonido.AudioScore();
        puntos.GanarPunto();
            

    }

}
