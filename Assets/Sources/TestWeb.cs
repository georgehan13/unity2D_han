﻿using UnityEngine;
using System.Collections;

public class TestWeb : MonoBehaviour 
{
	WWW www = null;
	bool isDownLoad = false;


	void Start() 
	{
		StartCoroutine(Call ());
	}

	IEnumerator Call()
	{
		www = new WWW("http://180.70.94.180/test.png");
		yield return www;

		if(www.isDone == true)
		{
			isDownLoad = true;
			print("완료!!!");
		}
	}

	void OnGUI()
	{
		if(isDownLoad == true)
		{
			GUI.Box (new Rect(0,0,64,64), www.texture);
		}
	}

	void Update()
	{
		if(isDownLoad == false)
		{
			print ("Progress" + www.progress);
		}
	}
}
