using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine;


public class PisoPerder : MonoBehaviour
{
    public Vidas vidas;
    private bool gameOver;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        vidas.PerderVida();        
    }
}
