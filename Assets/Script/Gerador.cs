using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerador : MonoBehaviour
{ 

    public static int AondeEsta = 0;   
    public static int pontuacao;
    public Text pontuacaoText, CronometroText;
    public float LimiteEsquerdo, LimiteDireito, Intervalo, intervaloTotal;
    public GameObject[] letrasPrefab;
    public static  int letraAtual = 0;
    public static int LetrasEmCena = 0;
    public static bool isRunning = true;
    public GameObject ResultadoDoJogo;
    public GameObject Obj1;
    public static int vMaximo;
    public bool b = false;
    public   float cronometro;

     public   float cronometroFinal;

    public static Gerador Instance;
  
    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        cronometro = Time.time;
        ResultadoDoJogo.SetActive(false);
        isRunning = true;
        StartCoroutine(Criador());
        vMaximo = letrasPrefab.Length -1;
    }
     void FixedUpdate()
    {
        pontuacaoText.text = pontuacao.ToString();
       // print(LetrasEmCena);
       //print(vMaximo);
        if (letraAtual == letrasPrefab.Length)
        {      
            StopCoroutine(Criador());
        }
    }
    public void Terminando()
    {
        if (pontuacao == vMaximo + 1)
        {
             cronometroFinal =     cronometro/5;
            Final();
            //print("tempo total é :" + cronometroFinal);
            // Gerador.Instance.Terminando();
            CronometroText.text = "tempo de jogo :" + cronometroFinal.ToString() ;
            ResultadoDoJogo.SetActive(true);
            isRunning = false;
          //  print(intervaloTotal);
        }
    }
    void Update()
    {;
        Terminando();
        if (isRunning == true)
        {
            cronometro += Time.deltaTime;
        }
        if (letraAtual >= vMaximo)
        {
            StopCoroutine(Criador());
       }
        if (b == true)
        {
          //  Final();
         
        }
    }
    
    IEnumerator Final()
    {
        print("foi o final");
       // isRunning = false;
        StopCoroutine(Criador());
        yield return new WaitForSeconds(2.0f);
      //  CronometroText.text = "tempo de jogo :" + cronometroFinal.ToString();
        ResultadoDoJogo.SetActive(true);
        Obj1.SetActive(false);

    }
    public void Disparar()
    {
        StartCoroutine(Criador());

    }

    IEnumerator Criador()
    {
        
        if (letraAtual <= vMaximo )
        {
            yield return new WaitForSeconds(Intervalo);
            Vector3 p = new Vector3(Random.Range(6, 11), Random.Range(6, -5), Random.Range(-3, 5));
            Instantiate(letrasPrefab[letraAtual], p, letrasPrefab[letraAtual].transform.rotation);
       
        }
     
        //if (LetrasEmCena == 0 && letraAtual < vMaximo)
        //{
        // // StartCoroutine(Criador());

        //}
     
        LetrasEmCena++;
     //   intervaloTotal += Intervalo;
       // print(intervaloTotal);
    }
   
}
