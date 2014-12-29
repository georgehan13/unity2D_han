using UnityEngine;
using System.Collections;

public class MissileProcess : MonoBehaviour 
{
	public GameObject missile = null;
	public GameObject missilePosition = null;

	float interval = 0;
	float intervalMax = 0.1f;


	void Update () 
	{
		interval += Time.deltaTime;
		if(interval > intervalMax)
		{
			GameObject obj = Instantiate(missile) as GameObject;
			//obj.transform.position = this.transform.position;
			obj.transform.position = missilePosition.transform.position;


			interval = 0;
		}
	
	}
}
