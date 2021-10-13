using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    [SerializeField]
    private float speed = 100f;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float HitFactor(Vector2 ball, Vector2 player, float playerWidth)
    {   
        //
        return (ball.x - player.x) / playerWidth;
    }

    private void OnCollisionEnter2D(Collision2D col) {
        {
            if(col.gameObject.name == "Racket")
            {
                float x = HitFactor(transform.position,col.transform.position, col.collider.bounds.size.x );

                Vector2 dir = new Vector2(x, 1).normalized;

                body.velocity = dir * speed;



            }
        }
    }
}
