using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public GameObject bala;
    public GameObject Posicaobala;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(bala, Posicaobala.transform.position, Posicaobala.transform.rotation);
            //projetil.velocity = transform.up * velocidadeProjetil;
        }
    }
}