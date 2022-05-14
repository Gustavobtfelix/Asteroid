using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    public TMP_Text textoPontos;
    public int pontuacao;
    
    public void Awake()
    {
        textoPontos.text = "Pontos: " + pontuacao;
        MeteoroBehavior.EventoAsteroideDestruido += AsteroidDestruido;
    }
    
    void    AsteroidDestruido()
    {
        Debug.Log("AsteroideDestruido");
        pontuacao += 1;
    }
    
    void OnDestroy()
    {
        MeteoroBehavior.EventoAsteroideDestruido -= AsteroidDestruido;
    }
    
    void AtualizacaoTextoPontos ()
    {
        textoPontos.text = pontuacao.ToString();
    }
    
}
