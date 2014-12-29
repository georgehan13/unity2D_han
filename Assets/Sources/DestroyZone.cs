using UnityEngine;
using System.Collections;

public class DestroyZone : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (other.gameObject);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		//Destroy (other.gameObject);
	}

}
