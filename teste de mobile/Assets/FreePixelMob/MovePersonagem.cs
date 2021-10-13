using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersonagem : MonoBehaviour
{
    Rigidbody2D rb2D;
    Animator playerAnim;
    public float velocity, speed, jumpForce;
    SpriteRenderer sprite;
    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        playerAnim = gameObject.GetComponent<Animator>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(speed);
    }

    void Move(float speed) 
    {
        rb2D.transform.Translate(speed * Time.deltaTime, 0, 0);
        playerAnim.SetBool("walk", true);

        Flip();
    }

    private void Flip()
    {
        if(speed < 0)
        {
            if(sprite.flipX == false) 
            {
                sprite.flipX = true;
            }
        }
        if(speed > 0) 
        {
            if(sprite.flipX == true) 
            {
                sprite.flipX = false;
            }
        }
    }

    public void MoveRight() 
    {
        speed = velocity;
    }
    public void MoveLeft() 
    {
        speed = -velocity;
    }
    public void StopMove() 
    {
        speed = 0;
    }
    
    public void Jump() 
    {
        if(canJump) 
        {
          rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            canJump = true;
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            canJump = false;
        }
    }
}
