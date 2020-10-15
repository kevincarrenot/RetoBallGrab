using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullBall : MonoBehaviour
{
    // Start is called before the first frame update
    public int ballPooll = 5;
    public float posicionY = 6f;
    private int currentBall;

    public GameObject balonSoccer;
    private Vector2 objectPoolPosition = new Vector2(0, 7);

    private GameObject[] balones;
    private float tiempoDeObjetos;
    public float spawnRate = 3;
    public float ballMin = -6f;
    public float ballMax = 7f;
    // Start is called before the first frame update
    void Start()
    {
        balones = new GameObject[ballPooll];
        for (int i = 0; i < ballPooll; i++)
        {
            balones[i] = Instantiate(balonSoccer, objectPoolPosition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        tiempoDeObjetos += Time.deltaTime;
        if (!gestorDelJuego.instance.gameOver && tiempoDeObjetos >= spawnRate)
        {
            tiempoDeObjetos = 0;
            float posX = Random.Range(ballMin, ballMax);
            balones[currentBall].transform.position = new Vector3(posX, posicionY);
            currentBall++;
            if (currentBall >= ballPooll)
            {
                currentBall = 0;
            }
            // Y 3 Y -1
            // X
        }
    }
}
