using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    public float velocidade = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    // Update is called once per frame
    void Update()
    {

        float movimento = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float voando = Input.GetAxisRaw("vertical") * Time.deltaTime;
        transform.position += new Vector3(movimento * velocidade, 0);

    }
}
