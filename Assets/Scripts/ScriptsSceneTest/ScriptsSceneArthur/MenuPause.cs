using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour {

	private bool paused = false;
	private float buttonpause1;
	private float buttonpause2;
	private float buttonpause3;
	private float buttonpause4;



	
	// Update is called once per frame
	void Update () 
	{
		buttonpause1 = Input.GetAxis ("J1Sart");
		buttonpause2 = Input.GetAxis ("J2Sart");
		buttonpause3 = Input.GetAxis ("J3Sart");
		buttonpause4 = Input.GetAxis ("J4Sart");

		if (buttonpause1 < 0.70f)
		{
			Pause();
		}

		if (buttonpause2 < 0.70f)
		{
			Pause();
		}

		if (buttonpause3 < 0.70f)
		{
			Pause();
		}

		if (buttonpause4 < 0.70f)
		{
			Pause();
		}
	}

	public void Pause ()
	{

	paused = !paused;

		if (paused)
		{
			Time.timeScale = 0;
		}

		else 
		{
			Time.timeScale = 1;
		}
	}
}


