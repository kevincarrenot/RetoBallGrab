using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int puntaje =0;
    public Text textoScore;
    void Start()
    {
        ActualizarScore();

    }

    void ActualizarScore()
    {
        textoScore.text = "Score : " + Score.puntaje;
    }
    // Update is called once per frame
    public void GanarPunto()
    {
        Score.puntaje++;
        ActualizarScore();
    }
}
