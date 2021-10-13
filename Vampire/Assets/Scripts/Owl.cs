using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Owl : MonoBehaviour
{
    [SerializeField]
    private Sprite[] imagens;
    [SerializeField]
    private SpriteRenderer sr;
    [SerializeField]
    private int x = 1;

    void Start()
    {
        sr.sprite = imagens[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.tag == "Player")
        {
           
            sr.sprite = imagens [0];
        }
    }
}
