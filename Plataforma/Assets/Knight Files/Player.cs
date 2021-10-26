using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Ground Properties")]
    public LayerMask groundLayer;
    public float groundDistance;
    public bool isGrounded;
    public Vector3[] footOffset;


    public float speed = 2f;
    public float jumpForce = 2f;

    
    private Rigidbody2D rb;
    private Vector2 movement;
    private float xVelocity;


    private int direction = -1;
    private float originalXScale;

    RaycastHit leftCheck;
    RaycastHit rightCheck;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originalXScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        movement = new Vector2(horizontal, 0);

        if(xVelocity * direction < 0)
        {
            Flip();
        }
    }

    private void FixedUpdate() 
    {
        xVelocity = movement.normalized.x * speed;
        rb.velocity = new Vector2(xVelocity, rb.velocity.y);
    }

    private void Flip()
    {
        direction *= -1;
        Vector3 scale = transform.localScale;

        scale.x = originalXScale * direction;
        transform.localScale = scale;
    }
}
