using UnityEngine;

public class MoveVelocity : MonoBehaviour
{
    public float velocidade = 1;
    Rigidbody2D rigibody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rigibody = transform.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");
        rigibody.linearVelocity += new Vector2(movimento * velocidade, 0);

    }
}
