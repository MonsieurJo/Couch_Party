using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
using UnityEngine.UI;

public class MenuLobby : MonoBehaviour {

	public GameObject j1PushBUI;
	public GameObject j2PushAUI;
	public GameObject j2PushBUI;
	public GameObject j3PushAUI;
	public GameObject j3PushBUI;
	public GameObject j4PushAUI;
	public GameObject j4PushBUI;

	void Start () {

	}
	
	void Update () 
	{
		if (Input.GetKeyUp("r")){
			TogglePlayerOneEnd();
		}
		if(Input.GetKeyUp("h")){
			TogglePlayerTwoUI();
		}
		if(Input.GetKeyUp("j")){
			TogglePlayerThreeUI();
		}
		if(Input.GetKeyUp("k")){
			TogglePlayerFourUI();
		}
		if(Input.GetKeyUp("y")){
			TogglePlayerTwoUI2();
		}
		if(Input.GetKeyUp("u")){
			TogglePlayerThreeUI2();
		}
		if(Input.GetKeyUp("i")){
			TogglePlayerFourUI2();
		}
	}

	void TogglePlayerOneEnd ()
	{
		if (j1PushBUI.activeSelf)
		{
			SceneManager.LoadScene("SceneTestTransition");
		}
	}

	void TogglePlayerTwoUI ()
	{
		if (j2PushAUI.activeSelf)
		{
			j2PushAUI.SetActive(false);
			j2PushBUI.SetActive(true);
		}
	}

	void TogglePlayerTwoUI2 ()
	{
		if (!j2PushAUI.activeSelf)
		{
			j2PushAUI.SetActive(true);
			j2PushBUI.SetActive(false);
		}
	}

	void TogglePlayerThreeUI ()
	{
		if (j3PushAUI.activeSelf)
		{
			j3PushAUI.SetActive(false);
			j3PushBUI.SetActive(true);
		}
	}

	void TogglePlayerThreeUI2 ()
	{
		if (!j3PushAUI.activeSelf)
		{
			j3PushAUI.SetActive(true);
			j3PushBUI.SetActive(false);
		}
	}

	void TogglePlayerFourUI ()
	{
		if (j4PushAUI.activeSelf)
		{
			j4PushAUI.SetActive(false);
			j4PushBUI.SetActive(true);
		}
	}

	void TogglePlayerFourUI2 ()
	{
		if (!j4PushAUI.activeSelf)
		{
			j4PushAUI.SetActive(true);
			j4PushBUI.SetActive(false);
		}
	}
}