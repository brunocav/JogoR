using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontuacaoJogador : MonoBehaviour
{
    public Text pontuacao;

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void FixedUpdate()
    {
                pontuacao.text = "Pontuacao : "+Gerador.pontuacao.ToString();

    }
}
