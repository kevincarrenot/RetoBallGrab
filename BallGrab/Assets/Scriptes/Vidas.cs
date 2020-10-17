using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public static int vidas = 10;
    public Text textovidas;
    public GameObject gameover;
    public Movimiento mover;
    public GameObject balonesf;

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
