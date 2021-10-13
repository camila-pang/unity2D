using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour
{   
    private Vector2 velocidade; //camera
    private Transform player;

   

    public float smoothTimeX;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Vampire").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x,player.position.x,ref velocidade.x, smoothTimeX);//posicao corrente, atual(camera), target(posicao que estamos tentando alcancar, a posicao do nosso Player), velocidade, tempo que leva para alcancar o alvo, o player(apos o tempo ira estacionar)

        transform.position = new Vector3(posX, transform.position.y, transform.position.z);//posicao da camera, só vai alterar o eixo x


    }
}
