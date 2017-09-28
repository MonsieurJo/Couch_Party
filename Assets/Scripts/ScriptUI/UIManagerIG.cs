﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerIG : MonoBehaviour {

	public float timerMinutes;
	public float timerSecondes;
	public GameObject classement;
	public GameObject uiIG;
	public Text timer;
	private bool apB;
	private int plyrPause = -1;
	private bool isPaused = false;
	public GameObject pauseScreen;

	public Text scoreJ1;
	public Text scoreJ2;
	public Text scoreJ3;
	public Text scoreJ4;

	public int currentScoreJ1 = 0;
	public int currentScoreJ2 = 0;
	public int currentScoreJ3 = 0;
	public int currentScoreJ4 = 0;

	public GameObject decompteur;
	public float compteur;

	private Countdown GMS;

    private static UIManagerIG instance;
    public static UIManagerIG Instance()
    {
        return instance;
    }

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
		GMS = GameObject.Find ("UImanager").GetComponent<Countdown>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (apB == true && Input.GetButtonDown("J1B"))
		{
			SceneManager.LoadScene("ScenePierre");
		}

		TimerIG();
		AfficheTimer();
		ScoreManager();
	}

	void TimerIG () {

	if(GMS.counterDownDone == true)
	{

		if(timerMinutes < 0)
		{
			timerMinutes = 0;
		}

		if(timerSecondes < 0)
		{
			timerSecondes = 0;
		}

		if(timerSecondes > 0)
		{
			timerSecondes -= Time.deltaTime;
		}

		if (timerMinutes >= 1 && timerSecondes == 0)
		{
			timerSecondes = 59.0f;
			timerMinutes--;
		}

		if(timerMinutes == 0 && timerSecondes == 0)
		{
			classement.SetActive(true);
			uiIG.SetActive(false);
			Time.timeScale = 0;
			apB = true;
		}
	}

	}

	void AfficheTimer () {

		timer.text = timerMinutes.ToString("F0") + " m " + timerSecondes.ToString("F0") + " s ";
	}

    public void TogglePause(int plyr)
    {
    	if(isPaused && plyrPause == plyr)
    	{
    		pauseScreen.SetActive(false);
    		Time.timeScale = 1;
    		plyrPause = -1;
    	}
    	else if (isPaused && plyrPause != plyr)
    	{
    		return;
    	}
    	pauseScreen.SetActive(true);
    	Time.timeScale = 0;
    	plyrPause = plyr;
    }

    public void ScoreManager(){
    	scoreJ1.text = currentScoreJ1.ToString() + " points ";
    	scoreJ2.text = currentScoreJ2.ToString() + " points ";
    	scoreJ3.text = currentScoreJ3.ToString() + " points ";
    	scoreJ4.text = currentScoreJ4.ToString() + " points ";
    }

    public void AddScore(int playerNb, int scoreToAdd){
    	if (playerNb == 1){
    		currentScoreJ1 += scoreToAdd;
    	}else if (playerNb == 2){
    		currentScoreJ2 += scoreToAdd;
    	}else if (playerNb == 3){
    		currentScoreJ3 += scoreToAdd;
    	}else if (playerNb == 4){
    		currentScoreJ4 += scoreToAdd;
    	}
    }
}
