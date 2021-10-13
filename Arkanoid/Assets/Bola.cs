using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    public bool jogoIniciou;

    public float direcaoX;

    public float direcaoY;

    public Rigidbody2D oRigidbody2D;

    public AudioSource somDaBola;

    // Start is called before the first frame update
    void Start()
    {
        jogoIniciou = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            LancarBola();
        }
    }

    private void LancarBola()
    {
        if(jogoIniciou == false) 
        {
            oRigidbody2D.velocity = new Vector2(direcaoX, direcaoY);
            jogoIniciou = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        somDaBola.Play();
    }

}
