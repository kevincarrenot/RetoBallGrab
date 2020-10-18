using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public static int vidas = 3;
    public Text textovidas;
    public GameObject gameover;
    public Movimiento mover;
    public GameObject balonesf;
    public SoundSystem sonido;
    void Start()
    {
        ActualizarVidas();

    }

    void ActualizarVidas()
    {
        textovidas.text = "Vidas : " + Vidas.vidas;
    }
    // Update is called once per frame
    public void PerderVida()
    {

        if (vidas <= 0) return;
        
        Vidas.vidas--;
        ActualizarVidas();
        

        if (vidas <= 0)
        {
            sonido.AudioGameover();
            gameover.SetActive(true);
            Destroy(balonesf);
            mover.Reset();
        }
        else
        {
            mover.Reset();
        }





    }
}
