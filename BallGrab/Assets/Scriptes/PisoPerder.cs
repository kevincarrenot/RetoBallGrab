using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;


public class PisoPerder : MonoBehaviour
{
    //Vector3 posicionInicial;
    //float posX = Random.Range(-5f, 7f);
    public GameObject balonesKill;
    public Vidas vidas;
    public SoundSystem sonido;

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        vidas.PerderVida();
        sonido.AudioVida();
        //collision.gameObject.transform.position = new Vector3(0, -8, 0);

    }
}

