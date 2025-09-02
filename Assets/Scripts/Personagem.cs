using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    TextMeshProUGUI textomoedas;
    Transform projetil;
    Transform Inicio;
    public float velocidade = 5;
    public float velocidadeMaxima = 5;
    public float forcaPulo = 5;
    public Transform groundChecker;

    bool estaOlhandoParaDireita = true;
    bool podepular = true;

    Rigidbody2D rb;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        transform.position = Inicio.position;

        textomoedas = GameObject.Find("Text (TMP)").transform.GetComponent<TextMeshProUGUI>();
        projetil = GameObject.Find("tiro").transform;
        Inicio = GameObject.Find("Inicio").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) == true)


        {
            Transform instanciado = Instantiate(projetil);
            instanciado.position = transform.position;
            instanciado.GetComponent<projetil>().direcao = estaOlhandoParaDireita ? Vector3.right : Vector3.left;

        }


        float horizontal = Input.GetAxis("Horizontal");
        horizontal = horizontal * velocidade * Time.deltaTime;

        Vector2 movimento = new Vector2(horizontal, 0);

        rb.linearVelocity += movimento;
        rb.linearVelocityX = Mathf.Clamp(rb.linearVelocityX, -velocidadeMaxima, velocidadeMaxima);

        if(movimento.x == 0)
        {
            rb.linearVelocityX = 0;
        }

        //podepular = Physics2D.OverlapBox(
        //    groundChecker.position,
        //    groundChecker.GetComponent<BoxCollider2D>().bounds.size,
        //    0,
        //    Constraints.camadaChao
        //    );
        bool pulo = Input.GetButtonDown("Jump");
        if (pulo == true && podepular == true)
        {
            rb.AddForce(new Vector2(0, forcaPulo), ForceMode2D.Impulse);
            podepular = false;




        }
    }


       
}

