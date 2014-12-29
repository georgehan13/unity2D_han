﻿using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour 
{
	enum MonsterState
	{
		None = -1,
		Idle,
		Damage,
		Die
	}

	Animator animator = null;
	MonsterState state = MonsterState.None;

	void Start () 
	{
		animator = GetComponent<Animator>();
		state = MonsterState.Idle;
		animator.SetInteger("State", (int)state);

		//animator.SetBool ("Check", true);


	}

	void Update () 
	{
		/*
		if(Input.GetMouseButtonDown(0)==true)
		{
			animator.SetBool ("Check", true);
		}
		else if (Input.GetMouseButtonDown(1)==true)
		{
			animator.SetBool ("Check", false);
		}
		*/


	}
}
