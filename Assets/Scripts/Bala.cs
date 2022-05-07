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
        //    Instantiate(bala, PosicaoBala.transform.position, PosicaoBala.transform.rotation);
        }
    }
}