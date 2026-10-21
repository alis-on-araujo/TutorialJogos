
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float velocidade = 5f;
    public Vector2 direcao = Vector2.right;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 movimento = direcao.normalized * velocidade * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movimento);
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        VidaJogador jogador = colisao.gameObject.GetComponent<VidaJogador>();

        if (jogador != null)
        {
            jogador.ReceberDano();
        }

        Destroy(gameObject);
    }
}