using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour {

	private bool paused = false;
	public GameObject pause;
	public string MenuPrincipal;



	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown("p"));
		{
			Pause();
		}
	}

	public void Pause ()
	{
		 if(paused)
		 {
             paused = true;
             Time.timeScale = 0;
         }
         else if (paused = false)
         {
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


