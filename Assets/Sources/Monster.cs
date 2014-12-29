using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour 
{
	Animator animator = null;

	void Start () 
	{
		animator = GetComponent<Animator>();
		animator.SetBool ("Check", true);

	}

	void Update () 
	{
	
	}
}
