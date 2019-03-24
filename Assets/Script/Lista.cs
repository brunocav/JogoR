using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista : MonoBehaviour
{
    public static Lista Instance;
    float cronometro = 2.0f;
    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 2.1f);
        Gerador.letraAtual++;
        Gerador.LetrasEmCena--;

    }
  
    void OnMouseDown()
    {
        Debug.Log("foi");
        Gerador.pontuacao++;
        Gerador.Instance.Disparar();
        Destroy(gameObject);
      



    }
}
