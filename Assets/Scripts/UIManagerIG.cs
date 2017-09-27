using System.Collections;
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

	public GameObject decompteur;
	public float compteur;

	private Countdown GMS;

	// Use this for initialization
	void Start () {
		GMS = GameObject.Find ("UImanager").GetComponent<Countdown>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (apB == true && Input.GetKeyDown("b"))
		{
			SceneManager.LoadScene("ScenePierre");
		}

		TimerIG();
		AfficheTimer();
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
}
