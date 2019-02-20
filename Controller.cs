using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

	public GameObject button1;
	public GameObject button2;
	public GameObject button3;
	public GameObject button4;
	public GameObject button5;
	public GameObject button6;
	public GameObject button7;
	public GameObject button8;
	public GameObject bg1;
	public GameObject bg2;
	public GameObject bg3;
	public GameObject bg4;
	public GameObject bg5;
	public GameObject bg6;
	public GameObject bg7;
	public GameObject bg8;
	public GameObject bgselectedMage;
	public GameObject bgselectedNinja;
	public GameObject bgselectedColosso;
	public GameObject bgselectedGoblin;
	public GameObject bgselectedKhron;
	public GameObject bgselectedBruxo;
	public GameObject bgselectedTailWarrior;
	public GameObject bgselectedDemonio;
	public GameObject textHP;
	public GameObject upbutton;
	public GameObject downbutton;
	public GameObject passpageButton;
	public GameObject returnpageButton;
	public GameObject returnButton;

	//private int page;


	// Use this for initialization
	void Start () {

		//page = 1;

	}

	// Update is called once per frame
	void Update () {

		/*if (returnpageButton.activeSelf)
			page = 2;
		else if (passpageButton.activeSelf)
			page = 1;
		*/
	}

	public void Disapear ()
	{
		// page 1
		button1.SetActive (false);
		button2.SetActive (false);
		button3.SetActive (false);
		button4.SetActive (false);

		bg1.SetActive (false);
		bg2.SetActive (false);
		bg3.SetActive (false);
		bg4.SetActive (false);

		// page 2
		button5.SetActive (false);
		button6.SetActive (false);
		button7.SetActive (false);
		button8.SetActive (false);

		bg5.SetActive (false);
		bg6.SetActive (false);
		bg7.SetActive (false);
		bg8.SetActive (false);

		passpageButton.SetActive (false);
		returnpageButton.SetActive (false);

	}

	public void Appear()
	{
		textHP.SetActive (true);
		upbutton.SetActive (true);
		downbutton.SetActive (true);
		returnButton.SetActive (true);
	}

	public void passPage()
	{
		button1.SetActive (false);
		button2.SetActive (false);
		button3.SetActive (false);
		button4.SetActive (false);

		bg1.SetActive (false);
		bg2.SetActive (false);
		bg3.SetActive (false);
		bg4.SetActive (false);

		button5.SetActive (true);
		button6.SetActive (true);
		button7.SetActive (true);
		button8.SetActive (true);

		bg5.SetActive (true);
		bg6.SetActive (true);
		bg7.SetActive (true);
		bg8.SetActive (true);

		returnpageButton.SetActive (true);
		passpageButton.SetActive (false);
	}

	public void returnPage()
	{
		button1.SetActive (true);
		button2.SetActive (true);
		button3.SetActive (true);
		button4.SetActive (true);

		bg1.SetActive (true);
		bg2.SetActive (true);
		bg3.SetActive (true);
		bg4.SetActive (true);

		button5.SetActive (false);
		button6.SetActive (false);
		button7.SetActive (false);
		button8.SetActive (false);

		bg5.SetActive (false);
		bg6.SetActive (false);
		bg7.SetActive (false);
		bg8.SetActive (false);

		passpageButton.SetActive (true);
		returnpageButton.SetActive (false);
	}

	public void mageBg()
	{
		bgselectedMage.SetActive (true);
	}

	public void goblinBg()
	{
		bgselectedGoblin.SetActive (true);
	}

	public void colossoBg()
	{
		bgselectedColosso.SetActive (true);
	}

	public void ninjaBg()
	{
		bgselectedNinja.SetActive (true);
	}

	public void khronBg()
	{
		bgselectedKhron.SetActive (true);
	}

	public void bruxoBg()
	{
		bgselectedBruxo.SetActive (true);
	}

	public void tailwarriorBg()
	{
		bgselectedTailWarrior.SetActive (true);
	}

	public void demonioBg()
	{
		bgselectedDemonio.SetActive (true);
	}

	public void returnToStart()
	{
		bgselectedMage.SetActive (false);
		bgselectedColosso.SetActive (false);
		bgselectedGoblin.SetActive (false);
		bgselectedNinja.SetActive (false);
		bgselectedKhron.SetActive (false);
		bgselectedBruxo.SetActive (false);
		bgselectedTailWarrior.SetActive (false);
		bgselectedDemonio.SetActive (false);

		button1.SetActive (true);
		button2.SetActive (true);
		button3.SetActive (true);
		button4.SetActive (true);
		bg1.SetActive (true);
		bg2.SetActive (true);
		bg3.SetActive (true);
		bg4.SetActive (true);

		textHP.SetActive (false);
		upbutton.SetActive (false);
		downbutton.SetActive (false);
		returnButton.SetActive (false);

		passpageButton.SetActive (true);
	}
		
}
