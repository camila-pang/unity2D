using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Controller : MonoBehaviour
{

    public int totalScore;
    public Text scoreText;
    

    


    public GameObject gameOver;
    private GameObject gameWin;
    
    public static Controller instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        gameWin = GameObject.FindWithTag("GameWin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();


    }
    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);

        
    }

    public void Quit()
    {   

        SceneManager.LoadScene("Menu");
    }

    public void ShowGameWin()
    {
        gameWin.SetActive(true);
    }

    public void Close() {
        Application.Quit();
    }
   
   
}
