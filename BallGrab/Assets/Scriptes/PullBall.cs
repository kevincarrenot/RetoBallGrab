﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pullBall : MonoBehaviour
{
    public GameObject balon;
     private float tiempoDeObjetos;
     public float spawnRate = 3;


     public void Update()
     {
         GenerarPull();

     }

     public void GenerarPull()
     {
         tiempoDeObjetos += Time.deltaTime;
         if (tiempoDeObjetos >= spawnRate)
         {

             tiempoDeObjetos = 0;
             float posX = Random.Range(-4f, 4f);
              //pull
             GameObject objeto= Instantiate(balon, new Vector3(0, -90, 0), Quaternion.identity);
            


        }
     }
    

}
    







