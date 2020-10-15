using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed,0);
    }
}
