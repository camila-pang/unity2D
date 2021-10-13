using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{

    public float speed;
    public float moveTime;

    private bool dirUp;
    private float timer;
  
    void Update()
    {
        if(dirUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else{
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
