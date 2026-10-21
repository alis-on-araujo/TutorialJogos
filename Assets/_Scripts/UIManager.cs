using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public TMP_Text textoTempo;
    public float tempoLimite = 20f;

    private float tempoRestante;

    void Start()
    {
        tempoRestante = tempoLimite;
        AtualizarTempo();
    }

    void Update()
    {
        if (GameController.gameOver)
        {
            endGamePanel.SetActive(true);
            return;
        }

        tempoRestante = Mathf.Max(0f, tempoRestante - Time.deltaTime);
        AtualizarTempo();

        if (tempoRestante <= 0f)
        {
            GameController.Perder();
            endGamePanel.SetActive(true);
        }
    }

    void AtualizarTempo()
    {
        textoTempo.text = tempoRestante.ToString("F1") + " s";
    }
}