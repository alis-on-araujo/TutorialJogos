using UnityEngine;
using TMPro;

public class VidaJogador : MonoBehaviour
{
    public int vidas = 3;
    public TMP_Text textoVidas;

    void Start()
    {
        AtualizarVidas();
    }

    void AtualizarVidas()
    {
        textoVidas.text = new string('♥', vidas);
    }

    public void ReceberDano()
    {
        if (vidas <= 0)
        {
            return;
        }

        vidas--;
        AtualizarVidas();

        if (vidas == 0)
        {
            GameController.Perder();
        }
    }
}