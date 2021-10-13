using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{   

    private Rigidbody2D ObstaculoRB;

    private GameController _GameController;

   
    // Start is called before the first frame update
    void Start()
    {
         ObstaculoRB = GetComponent<Rigidbody2D>();

         _GameController = FindObjectOfType(typeof(GameController)) as GameController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {
        MoveObjeto();
    }

    void MoveObjeto() 
    {
        transform.Translate(Vector2.left * _GameController._ObstaculoVelocidade * Time.smoothDeltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.tag == "Player") 
        {

        }
    }

    private void OnBecameInvisible() 
    {
        Destroy(this.gameObject);
    }
}
