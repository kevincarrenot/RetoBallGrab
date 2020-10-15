using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LogicaBall : MonoBehaviour
{
    public Score puntos;

  
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        puntos.GanarPunto();
    }
}
