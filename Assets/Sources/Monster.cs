using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour 
{
	Animator animator = null;

	void Start () 
	{
		animator = GetComponent<Animator>();
		//animator.SetBool ("Check", true);

	}

	void Update () 
	{
		if(Input.GetMouseButtonDown(0)==true)
		{
			animator.SetBool ("Check", true);
		}
		else if (Input.GetMouseButtonDown(1)==true)
		{
			animator.SetBool ("Check", false);
		}
	
	}
}
