using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] public float aceleracao = 3.0f;
    public float rotacao = 180.0f;
    public float velocidadeMax = 10.0f;

    public float velocidadeMin = 0.0f;
    Vector3 inicial = new Vector3 (0.0f, -4.0f, 0.0f);

    public Rigidbody2D jogadorRb;
    public Rigidbody2D prefabProjetil;
    public Rigidbody2D posicaobala;
    public float velocidadeProjetil = -3.0f;


    void Start()
    {
        transform.position = inicial;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D projetil = Instantiate(prefabProjetil, jogadorRb.position, Quaternion.identity);
            projetil.velocity = transform.up * velocidadeProjetil;
        }
    }

        //Fixed bloqueia a alteração pelo unity
     void FixedUpdate()
    {
        //Debug.Log(jogadorRb.velocity);
        if(Input.GetKey(KeyCode.W))
        {
            Vector3 direcao = transform.up * -aceleracao;            //Vector3 direcao = new Vector3 (0.0f, 1.0f * aceleracao, 0.0f);
            jogadorRb.AddForce(direcao, ForceMode2D.Force);         //Adiciona aceleração no jogadorRb
        }
        if(Input.GetKey(KeyCode.S))
        {
            Vector3 direcao = transform.up * aceleracao;
            jogadorRb.AddForce(direcao, ForceMode2D.Force); 
        
        }
        if(Input.GetKey(KeyCode.A))
        {
            jogadorRb.rotation += rotacao * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            jogadorRb.rotation += -rotacao * Time.deltaTime;
        }
        if(jogadorRb.velocity.magnitude > velocidadeMax)
        {
            jogadorRb.velocity = Vector2.ClampMagnitude(jogadorRb.velocity, velocidadeMax);//velocidade atual com o limite de velocidade
        }
        else if(jogadorRb.velocity.magnitude <= velocidadeMin)
        {
            transform.position = transform.position + new Vector3(0.0f,  0.0f, 0.0f);
            //jogadorRb.velocity = Vector2.ClampMagnitude(jogadorRb.velocity, velocidadeMin);//velocidade atual com o limite de velocidade
        }
    }

    void OnTriggerEnter2D (Collider2D outro)
    {
        Destroy(gameObject);
        Debug.Log("F");
    }
}
