using System;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private AudioSource audio;
    public TMP_Text textoVidas;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            return;
        }
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coletavel"){
            audio.Play();
            GameController.Collect();
            other.GetComponent<SpriteRenderer>().color = Color.green;
            other.tag = "Untagged";
        }
            
    }
}
