using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	float speed = 350;

	void FixedUpdate()
	{
		float dirX = 0;
		if(Input.GetMouseButton (0) == true)
		{
			dirX = Input.GetAxis ("Mouse X");
		}

		if(Input.GetMouseButtonDown(0) == true)
		{
			dirX = 0; // 처음 실행시 초기와
		}

		float velocityX = dirX * speed * Time.deltaTime;
		this.rigidbody2D.velocity = new Vector2(velocityX, 0);
	}

	/*
	void Update () 
	{
		float dirX = Input.GetAxis("Horizontal");
		float dirY = Input.GetAxis ("Vertical");

		float velocityX = dirX * speed * Time.deltaTime;
		float velocityY = dirY * speed * Time.deltaTime;

		this.transform.Translate(velocityX, velocityY, 0);

		//print (dir);
	}
	*/
}
