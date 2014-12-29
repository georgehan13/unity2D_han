using UnityEngine;
using System.Collections;

public class Vector2Ex
{
	public Vector2Ex(float left, float right)
	{
		x=left;
		y=right;
	}

	public void Call()
	{
		Debug.Log ("X" + x);
		Debug.Log ("Y" + y);
	}


	float x;
	float y;
}

public class Missile : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		//Vector2Ex vector2 = new Vector2Ex(0,5);
		//vector2.Call ();
	
		this.rigidbody2D.velocity = new Vector2(0, 7);
	}
}