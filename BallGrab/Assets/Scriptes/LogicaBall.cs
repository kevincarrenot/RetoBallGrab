using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaBall : MonoBehaviour
{
    private bool gameOver;
    private Rigidbody2D rb2d;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver = true;
        Debug.Log("perdewr");
    }
}
