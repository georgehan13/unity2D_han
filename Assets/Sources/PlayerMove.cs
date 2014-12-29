using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	float speed = 5;

	void Update () 
	{
		float dirX = Input.GetAxis("Horizontal");
		float dirY = Input.GetAxis ("Vertical");

		float velocityX = dirX * speed * Time.deltaTime;
		float velocityY = dirY * speed * Time.deltaTime;

		this.transform.Translate(velocityX, velocityY, 0);

		//print (dir);
	}
}
