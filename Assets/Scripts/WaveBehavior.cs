using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveBehavior : MonoBehaviour
{
public MeteoroBehavior prefabAsteroid; //Declaração do componente de Script
public int quantidadeAsteroides = 4;
    
    void Start()
    {
        for (int i =0; i < quantidadeAsteroides; i++) //Laço de Repetição
        {
            Vector3 posicao = new Vector3(0.0f, 0.0f, 0.0f);
            Instantiate(prefabAsteroid, posicao, Quaternion.identity);
        }
    }

}
