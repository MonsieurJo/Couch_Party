using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour {

    public GameObject moveTutorial;
    public GameObject grabTutorial;

    public GameObject stockTutorial;
    public GameObject throwTutorial;

        // DEBUT LISTE JOYSTICKS
    // Joueur 1
        float j1AxisV = Input.GetAxis("J1Vertical");
        float j1AxisH = Input.GetAxis("J1Horizontal");

    // Joueur 2
        float j2AxisV = Input.GetAxis("J2Vertical");
        float j2AxisH = Input.GetAxis("J2Horizontal");

    // Joueur 3
        float j3AxisV = Input.GetAxis("J3Vertical");
        float j3AxisH = Input.GetAxis("J3Horizontal");

    //Joueur 4
        float j4AxisV = Input.GetAxis("J4Vertical");
        float j4AxisH = Input.GetAxis("J4Horizontal");
        // FIN LISTE JOYSTICKS




    // Use this for initialization
    void Start () // LANCE LE LAYOUT DEPLACEMENTS
    {
        moveTutorial.SetActive(true);
             
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (moveTutorial == true)
        {
            if (j1AxisH < 0 || j1AxisH > 0 || j1AxisV < 0 || j1AxisV > 0)
            {
                activateGrabLayout();
            }
        }

        if (grabTutorial == true)
        {

        }
    }

    IEnumerator activateGrabLayout() // LANCE LE LAYOUT GRAB
    {
        StartCoroutine(activateGrabLayout());
        moveTutorial.SetActive(false);
        yield return new WaitForSeconds(2);
        grabTutorial.SetActive(true);
    }

    IEnumerator activateThrowLayout() // LANCE LE LAYOUT JETER
    {
        StartCoroutine(activateStockLayout());
        grabTutorial.SetActive(false);
        yield return new WaitForSeconds(2);
        throwTutorial.SetActive(true);
    }

    IEnumerator activateStockLayout() // LANCE LE LAYOUT RANGER
    {
        StartCoroutine(activateThrowLayout());
        throwTutorial.SetActive(false);
        yield return new WaitForSeconds(2);
    }

}
