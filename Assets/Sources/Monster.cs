using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour 
{
	enum MonsterState
	{
		None = -1,
		Idle,
		Damage,
		Die
	};

	Animator animator = null;
	MonsterState state = MonsterState.None;

	bool isDamage = false;
	int hp = 5;

	void Start () 
	{
		animator = GetComponent<Animator>();
		state = MonsterState.Idle;
		animator.SetInteger("State", (int)state);
		//animator.SetBool ("Check", true);

	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		isDamage = true;
		state = MonsterState.Damage;
		animator.SetInteger("State", (int)state);

		//hp -= 2;
		hp--;

		if (hp <= 0)
		{
			state = MonsterState.Die;
			animator.SetInteger("State", (int)state);
		}
	}


	public void Damage()
	{
		if(isDamage == true)
		{
			isDamage = false;
			return;
		}

		state = MonsterState.Idle;
		animator.SetInteger("State", (int)state);
	}

	public void Die()
	{
		Destroy(this.gameObject);
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
