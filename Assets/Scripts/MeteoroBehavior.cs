using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroBehavior : MonoBehaviour
{
    public static System.Action EventoAsteroideDestruido = null;

    public Rigidbody2D asteroidRB;
    public MeteoroBehavior AsteroideMenor;
    public float velocidadeMaxima = 1.0f;
    public GameObject projetil;
    public int quantidadeFragmentos = 3;
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
        
        for(int i = 0; i < quantidadeFragmentos; i++)
        {
            Instantiate(AsteroideMenor, asteroidRB.position, Quaternion.identity);
        }
        if (EventoAsteroideDestruido != null)
        {
            EventoAsteroideDestruido();
        }
    }
}
