using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour
{

    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject smoke;
    private int Score = 1;

    
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

  

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            smoke.SetActive(true);

           Controller.instance.totalScore += Score;
           Controller.instance.UpdateScoreText();
            
            Destroy(gameObject, 0.5f);
        }
    }
}
