using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Toques : MonoBehaviour
{   
    public Text _QtdToques;

    public Transform ponteiroMouse;
    private Vector3 posicaoToque;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _QtdToques.text = Input.touchCount.ToString();//quantos dedos tocam na tela

        if(Input.touchCount > 0)//se for maior que 0, existe toque no celular, portanto
        {
                Touch toque = Input.touches[0];

                posicaoToque = Camera.main.ScreenToWorldPoint(toque.position);
        }
    }
}
