using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    Vector3 posicionInicial;
    public GameObject balones;

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

    }
}
