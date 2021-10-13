using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerGame : MonoBehaviour {

    private int score;
    public Text txtScore;
    public GameObject hitprefab;

    public Sprite[] imagensVida;
    public Image barraVida;

    public AudioSource fxGame, fxMusicGame;
    public AudioClip fxCenouraColetada;
    public AudioClip fxExplosao;
    public AudioClip fxDie;

    public void Pontuacao( int qtdPontos )
    {
        score += qtdPontos;
        txtScore.text = score.ToString();

        // Som da coleta da cenoura
        //fxGame.PlayOneShot(fxCenouraColetada);

    }

    public void BarraVida( int healthvida )
    {
        barraVida.sprite = imagensVida[healthvida];  // 3 2 1 0
    }
    

   

}
