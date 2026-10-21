using UnityEngine;

public class Totem : MonoBehaviour
{
    public GameObject tiroPrefab;
    public Transform pontoDeDisparo;
    public Vector2 direcao = Vector2.up;
    public float intervalo = 2f;

    private float tempo;

    void Update()
    {
        tempo += Time.deltaTime;

        if (tempo >= intervalo)
        {
            GameObject novoTiro = Instantiate(
                tiroPrefab,
                pontoDeDisparo.position,
                Quaternion.identity
            );

            novoTiro.GetComponent<Tiro>().direcao = direcao;

            tempo = 0f;
        }
    }
}