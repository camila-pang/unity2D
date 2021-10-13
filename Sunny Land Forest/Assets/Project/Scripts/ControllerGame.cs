using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerGame : MonoBehaviour
{

    private int score;
    public Text txtScore;
    public GameObject hitprefab;

    public Sprite[] imagensVida;
    public Image barraVida;


    public AudioSource fxGame, fxMusicGame;
    public AudioClip fxCenouraColetada;
    public AudioClip fxExplosao;
    public AudioClip fxDie;

    public void Pontuacao(int qtdPontos)
    {
        score += qtdPontos;
        txtScore.text = score.ToString();

        //som da coleta da cenoura
        fxGame.PlayOneShot(fxCenouraColetada);
    }    // Start is called before the first frame update
    

    public void BarraVida(int health) 
    {
        barraVida.sprite = imagensVida[health];
    }
}
