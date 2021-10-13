using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    [SerializeField]
    private float speed = 150;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void FixedUpdate() 
     {
         float h = Input.GetAxis("Horizontal");
         body.velocity = Vector2.right * h * speed;
     }
}
