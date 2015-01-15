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
	}

	//public PlayerState playerState = null; < 메모리 로드 전이라 연결안됨.
	PlayerState playerState = null;

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

		this.rigidbody2D.velocity = new Vector2(0,-3);

		playerState = GameObject.Find ("Player").GetComponent<PlayerState>();
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(state == MonsterState.Die)
		{
			return;
		}


		int layerIndex = other.gameObject.layer;
		//if(layerIndex == 8) no8 could be interupt by engine
		if(layerIndex == LayerMask.NameToLayer("Missile"))
		{
			Destroy(other.gameObject);
		}


		isDamage = true;
		state = MonsterState.Damage;
		animator.SetInteger("State", (int)state);

		//hp -= 2;
		hp--;

		if (hp <= 0)
		{
			state = MonsterState.Die;
			animator.SetInteger("State", (int)state);
			playerState.MonsterDieCount++;
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
