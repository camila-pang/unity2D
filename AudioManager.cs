﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	//Músicas
	public AudioClip[] clips;
	public AudioSource musicaBG;
   



	public static AudioManager instance;

	void Awake()
	{
     
		if(instance == null)
		{
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		}
		else
		{
			Destroy (gameObject);
		}
	}

    
	
	// Update is called once per frame
	void Update () {

		if(!musicaBG.isPlaying)
		{
			musicaBG.clip = GetRandom ();
			musicaBG.Play ();
		}

		/*if(panelWin.activeInHierarchy)
		{
			musicaBG.Stop();
		}*/
	}

	AudioClip GetRandom()
	{
		return clips [Random.Range (0, clips.Length)];
	}

}
