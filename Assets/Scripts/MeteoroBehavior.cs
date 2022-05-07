using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroBehavior : MonoBehaviour
{
    public Rigidbody2D asteroidRB;
    public float velocidadeMaxima = 1.0f;
    public GameObject projetil;
    void Start()
    {                               //gera (x, y) randomico
        Vector2 direcao = Random.insideUnitCircle;
        direcao = direcao * velocidadeMaxima;
        //Debug.Log(direcao);
        asteroidRB.velocity = direcao;
    }

    void OnTriggerEnter2D (Collider2D projetil)
    {
        Destroy(gameObject);
        Destroy(projetil.gameObject);
    }
}
