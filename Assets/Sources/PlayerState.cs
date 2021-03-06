﻿using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour 
{
	public UILabel goldLabel = null;
	public UILabel meterLabel = null;
	public UILabel scoreLabel = null;

	int goldCount = 0;
	float meterCount = 0;
	int monsterDieCount = 0;
	int scoreCount = 0;

	bool isDead = false;

	public int MonsterDieCount
	{
		get
		{
			return monsterDieCount;
		}

		set
		{
			monsterDieCount = value;
			print ("monsterDieCount : " + monsterDieCount);
		}
	}

	void Start () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.layer == LayerMask.NameToLayer("Monster"))
		{
			//Application.LoadLevel ("Result");
			isDead = true;
		}

		else if(other.gameObject.layer == LayerMask.NameToLayer("Meteorite"))
		{
			//Application.LoadLevel ("Result");
			isDead = true;
		}

		else if(other.gameObject.layer == LayerMask.NameToLayer("Gold"))
		{
			goldCount++;
			goldLabel.text = "Gold : "+goldCount;

			Destroy(other.gameObject);
		}
	}
	
	void Update () 
	{
		if (isDead == true)
		{
			PlayerPrefs.SetInt("Score", scoreCount);
			//PlayerPrefs.SetString("Name", "kim");
			Application.LoadLevel ("Result");
			return;
		}

		meterCount += 1*Time.deltaTime;
		int iMeter = (int)meterCount;

		meterLabel.text = "" + iMeter + "M";

		scoreCount = goldCount + iMeter + monsterDieCount;
		scoreLabel.text = "Score : " + scoreCount;


	
	}


}
