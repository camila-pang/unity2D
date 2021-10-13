using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject win;
    

    void OnCollisionEnter2D(Collision2D  collision) {
        {
            if(collision.gameObject.tag == "Player")
            {   
                
                win.SetActive(true);
                
            }
        }
    }
}
