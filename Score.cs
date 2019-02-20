using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	Text HP;
	private int HPatual;
	public int HPinicial = 30;

	// Use this for initialization
	void Start () {

		HPatual = HPinicial;
		HP = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		HP.text = "" + HPatual;

	}

	public void Increase()
	{
		HPatual++;
	}

	public void Decrease()
	{
		HPatual--;
		if (HPatual < 0)
			HPatual = 0;
	}

	public void startHP()
	{
		HPatual = HPinicial;
	}

} 
