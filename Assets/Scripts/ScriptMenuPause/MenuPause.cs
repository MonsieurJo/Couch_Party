using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour {

	private bool paused;
	private bool buttonpause1 = false;
	private bool buttonpause2 = false;
	private bool buttonpause3 = false;
	private bool buttonpause4 = false;
	public GameObject pause;
	public string MenuPrincipal;



	
	// Update is called once per frame
	void Update () 
	{
		buttonpause1 = Input.GetButtonDown ("J1Start");
		buttonpause2 = Input.GetButtonDown ("J2Start");
		buttonpause3 = Input.GetButtonDown ("J3Start");
		buttonpause4 = Input.GetButtonDown ("J4Start");

		if (buttonpause1 = true)
		{
			Pause();
		}

		if (buttonpause2 = true)
		{
			Pause();
		}

		if (buttonpause3 = true)
		{
			Pause();
		}

		if (buttonpause4 = true)
		{
			Pause();
		}

		if (Input.GetKeyDown("p"));
		{
			Pause();
		}
	}

	public void Pause ()
	{
		 if(paused)
		 {
             paused = false;
             Time.timeScale = 0;
         }
         else
         {
             paused = true;
             Time.timeScale = 1;
         }
	}

	public void Continue ()
	{
		pause.SetActive(false);

	}

	public void Quit ()
	{
		SceneManager.LoadScene (MenuPrincipal);
	}
}


