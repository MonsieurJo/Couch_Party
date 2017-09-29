using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassementManager : MonoBehaviour {


// 	private int scoreJ1;
// 	private int scoreJ2;
// 	private int scoreJ3;
// 	private int scoreJ4;

// 	public Text firstPlayer;
// 	public Text secondPlayer;
// 	public Text thirdPlayer;
// 	public Text fourthPlayer;

// 	public GameObject uiManagerIG;

// 	// Use this for initialization
// 	void Start () {
// 		scoreJ1 = uiManagerIG.GetComponent<UIManagerIG>().DisplayScore(1);
// 		scoreJ2 = uiManagerIG.GetComponent<UIManagerIG>().DisplayScore(2);
// 		scoreJ3 = uiManagerIG.GetComponent<UIManagerIG>().DisplayScore(3);
// 		scoreJ4 = uiManagerIG.GetComponent<UIManagerIG>().DisplayScore(4);

// 		if (scoreJ1 > scoreJ2 && scoreJ2 > scoreJ3 && scoreJ3 > scoreJ4){
// 			firstPlayer.text = "Joueur 1 : "+scoreJ1+" points ";
// 			secondPlayer.text = "Joueur 2 : "+scoreJ2+" points ";
// 			thirdPlayer.text = "Joueur 3 : "+scoreJ3+" points ";
// 			fourthPlayer.text = "Joueur 4 : "+scoreJ4+" points ";
// 		} else if (scoreJ1 > scoreJ2 && scoreJ2 > scoreJ3 && scoreJ3 > scoreJ4){
// 			firstPlayer.text = "Joueur 1 : "+scoreJ1+" points ";
// 			secondPlayer.text = "Joueur 2 : "+scoreJ2+" points ";
// 			thirdPlayer.text = "Joueur 3 : "+scoreJ3+" points ";
// 			fourthPlayer.text = "Joueur 4 : "+scoreJ4+" points ";
// 		} else if (scoreJ1 > scoreJ2 && scoreJ2 > scoreJ3 && scoreJ3 > scoreJ4){
// 			firstPlayer.text = "Joueur 1 : "+scoreJ1+" points ";
// 			secondPlayer.text = "Joueur 2 : "+scoreJ2+" points ";
// 			thirdPlayer.text = "Joueur 3 : "+scoreJ3+" points ";
// 			fourthPlayer.text = "Joueur 4 : "+scoreJ4+" points ";
// 		} else if (scoreJ1 > scoreJ2 && scoreJ2 > scoreJ3 && scoreJ3 > scoreJ4){
// 			firstPlayer.text = "Joueur 1 : "+scoreJ1+" points ";
// 			secondPlayer.text = "Joueur 2 : "+scoreJ2+" points ";
// 			thirdPlayer.text = "Joueur 3 : "+scoreJ3+" points ";
// 			fourthPlayer.text = "Joueur 4 : "+scoreJ4+" points ";
// 		} else if (scoreJ1 > scoreJ2 && scoreJ2 > scoreJ3 && scoreJ3 > scoreJ4){
// 			firstPlayer.text = "Joueur 1 : "+scoreJ1+" points ";
// 			secondPlayer.text = "Joueur 2 : "+scoreJ2+" points ";
// 			thirdPlayer.text = "Joueur 3 : "+scoreJ3+" points ";
// 			fourthPlayer.text = "Joueur 4 : "+scoreJ4+" points ";
// 		} else if (scoreJ1 > scoreJ2 && scoreJ2 > scoreJ3 && scoreJ3 > scoreJ4){
// 			firstPlayer.text = "Joueur 1 : "+scoreJ1+" points ";
// 			secondPlayer.text = "Joueur 2 : "+scoreJ2+" points ";
// 			thirdPlayer.text = "Joueur 3 : "+scoreJ3+" points ";
// 			fourthPlayer.text = "Joueur 4 : "+scoreJ4+" points ";
// 		} else if (scoreJ1 > scoreJ2 && scoreJ2 > scoreJ3 && scoreJ3 > scoreJ4){
// 			firstPlayer.text = "Joueur 1 : "+scoreJ1+" points ";
// 			secondPlayer.text = "Joueur 2 : "+scoreJ2+" points ";
// 			thirdPlayer.text = "Joueur 3 : "+scoreJ3+" points ";
// 			fourthPlayer.text = "Joueur 4 : "+scoreJ4+" points ";
// 		} else if (scoreJ1 > scoreJ2 && scoreJ2 > scoreJ3 && scoreJ3 > scoreJ4){
// 			firstPlayer.text = "Joueur 1 : "+scoreJ1+" points ";
// 			secondPlayer.text = "Joueur 2 : "+scoreJ2+" points ";
// 			thirdPlayer.text = "Joueur 3 : "+scoreJ3+" points ";
// 			fourthPlayer.text = "Joueur 4 : "+scoreJ4+" points ";
// 		} else if (scoreJ1 > scoreJ2 && scoreJ2 > scoreJ3 && scoreJ3 > scoreJ4){
// 			firstPlayer.text = "Joueur 1 : "+scoreJ1+" points ";
// 			secondPlayer.text = "Joueur 2 : "+scoreJ2+" points ";
// 			thirdPlayer.text = "Joueur 3 : "+scoreJ3+" points ";
// 			fourthPlayer.text = "Joueur 4 : "+scoreJ4+" points ";
// 		} else if (scoreJ1 > scoreJ2 && scoreJ2 > scoreJ3 && scoreJ3 > scoreJ4){
// 			firstPlayer.text = "Joueur 1 : "+scoreJ1+" points ";
// 			secondPlayer.text = "Joueur 2 : "+scoreJ2+" points ";
// 			thirdPlayer.text = "Joueur 3 : "+scoreJ3+" points ";
// 			fourthPlayer.text = "Joueur 4 : "+scoreJ4+" points ";
// 		]
// 	}
	
// 	// Update is called once per frame
// 	void Update () {
		
// 	}
}