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
            float x = Random.Range(-11.0f, 11.0f);
            float y = Random.Range(-2.5f, 5.0f);
            Vector3 posicao = new Vector3(x, y, 0.0f);
            Instantiate(prefabAsteroid, posicao, Quaternion.identity);
        }
    }

}
