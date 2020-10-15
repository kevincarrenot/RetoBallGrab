using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public static int vidas = 3+1;
    public Text textovidas;
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
        Vidas.vidas--;
        ActualizarVidas();
    }
}
