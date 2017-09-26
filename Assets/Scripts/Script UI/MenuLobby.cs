using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
using UnityEngine.UI;

public class MenuLobby : MonoBehaviour {

	public GameObject j1PushBUI;
	public GameObject j1StartUI;
	public GameObject j2PushAUI;
	public GameObject j2PushBUI;
	public GameObject j2ImageNoir;
	public GameObject j2ImageBlanc;
	public GameObject j3PushAUI;
	public GameObject j3PushBUI;
	public GameObject j3ImageNoir;
	public GameObject j3ImageBlanc;
	public GameObject j4PushAUI;
	public GameObject j4PushBUI;
	public GameObject j4ImageNoir;
	public GameObject j4ImageBlanc;
	public GameObject tutoBlanc;

	void Start () {

	}
	
	void Update () 
	{
		if (Input.GetKeyUp("r")){
			TogglePlayerOneEnd();
		}
		if (Input.GetKeyUp("space")){
			TogglePlayerStart();
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
			SceneManager.LoadScene("ScenePierre");
		}
	}

    void TogglePlayerStart ()
    {
    	if (j1StartUI.activeSelf)
    	{
    		tutoBlanc.SetActive(true);
    	}
    }

	void TogglePlayerTwoUI ()
	{
		if (j2PushAUI.activeSelf)
		{
			j2PushAUI.SetActive(false);
			j2PushBUI.SetActive(true);
		}

		if (j2ImageNoir.activeSelf)
		{
			j2ImageNoir.SetActive(false);
			j2ImageBlanc.SetActive(true);
		}
	}

	void TogglePlayerTwoUI2 ()
	{
		if (!j2PushAUI.activeSelf)
		{
			j2PushAUI.SetActive(true);
			j2PushBUI.SetActive(false);
		}

		if (!j2ImageNoir.activeSelf)
		{
			j2ImageNoir.SetActive(true);
			j2ImageBlanc.SetActive(false);
		}
	}

	void TogglePlayerThreeUI ()
	{
		if (j3PushAUI.activeSelf)
		{
			j3PushAUI.SetActive(false);
			j3PushBUI.SetActive(true);
		}

		if (j3ImageNoir.activeSelf)
		{
			j3ImageNoir.SetActive(false);
			j3ImageBlanc.SetActive(true);
		}
	}

	void TogglePlayerThreeUI2 ()
	{
		if (!j3PushAUI.activeSelf)
		{
			j3PushAUI.SetActive(true);
			j3PushBUI.SetActive(false);
		}

		if (!j3ImageNoir.activeSelf)
		{
			j3ImageNoir.SetActive(true);
			j3ImageBlanc.SetActive(false);
		}
	}

	void TogglePlayerFourUI ()
	{
		if (j4PushAUI.activeSelf)
		{
			j4PushAUI.SetActive(false);
			j4PushBUI.SetActive(true);
		}

		if (j4ImageNoir.activeSelf)
		{
			j4ImageNoir.SetActive(false);
			j4ImageBlanc.SetActive(true);
		}
	}

	void TogglePlayerFourUI2 ()
	{
		if (!j4PushAUI.activeSelf)
		{
			j4PushAUI.SetActive(true);
			j4PushBUI.SetActive(false);
		}

		if (!j4ImageNoir.activeSelf)
		{
			j4ImageNoir.SetActive(true);
			j4ImageBlanc.SetActive(false);
		}
	}

	public void BouttonOui()
	{
		SceneManager.LoadScene("SceneTuto");
	}

	public void BouttonNon()
	{
		SceneManager.LoadScene("SceneGame");
	}
}