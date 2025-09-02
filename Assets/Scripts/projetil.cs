using UnityEngine;

public class projetil : MonoBehaviour
{

    public Vector3 direcao;
    public float velocidade = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void Start()
    {
        Destroy(transform.gameObject, 5);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direcao * velocidade * Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(transform.gameObject);
    }
}
