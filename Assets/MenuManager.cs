using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	public GameObject lobby;
	public GameObject startMenu;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayOnClick(){
		startMenu.SetActive(false);
		lobby.SetActive(true);
	}

	public void QuitOnClick(){
		Application.Quit();
		Debug.Log("Quit");
	}
}
