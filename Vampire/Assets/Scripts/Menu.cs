using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public static Menu instance;

    public GameObject[] button;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void ShowOptions()
    {
        button[0].SetActive(true);
    }

    public void ShowCredits()
    {
        button[1].SetActive(true);
    }

    public void Back()
    {   if(button[0].activeInHierarchy) 
        {
            button[0].SetActive(false);
        }else {
            button[1].SetActive(false);
        }
        //this.GameObject.SetActive(false);
       // GameObject.tag('panel').SetActive(true);
    }
    
}
