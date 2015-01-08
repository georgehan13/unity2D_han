using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour 
{

	void Start () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.layer == LayerMask.NameToLayer("Monster"))
		{
			Application.LoadLevel ("Result");
		}

		else if(other.gameObject.layer == LayerMask.NameToLayer("Meteorite"))
		{
			Application.LoadLevel ("Result");
		}

		else if(other.gameObject.layer == LayerMask.NameToLayer("Gold"))
		{
			Application.LoadLevel ("Result");
		}
	}
	
	void Update () 
	{
	
	}
}
