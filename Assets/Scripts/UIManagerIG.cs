using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerIG : MonoBehaviour {

	public float timerMinutes;
	public float timerSecondes;
	public GameObject classement;
	public GameObject uiIG;
	public Text timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		TimerIG();
		AfficheTimer();
	}

	void TimerIG () {

		if(timerMinutes < 0)
		{
			timerMinutes = 0;
		}

		if(timerSecondes < 0)
		{
			timerSecondes = 0;
		}


		if(timerMinutes == 0 && timerSecondes == 0)
		{
			classement.SetActive(true);
			uiIG.SetActive(false);
			Time.timeScale = 0;
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
	}

	void AfficheTimer () {

		timer.text = timerMinutes.ToString("F0") + " m " + timerSecondes.ToString("F0") + " s ";
	}
}
