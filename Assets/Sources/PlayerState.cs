using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour 
{
	public UILabel goldLabel = null;
	int goldCount = 0;

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
			goldCount++;
			goldLabel.text = "Gold : "+goldCount;

			Destroy(other.gameObject);
		}
	}
	
	void Update () 
	{
	
	}
}
