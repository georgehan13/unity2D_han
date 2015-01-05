using UnityEngine;
using System.Collections;

public class MonsterManager : MonoBehaviour 
{
	public GameObject enemy = null;
	float interval = 0;
	float intervalMax = 3;
	float startX = -2;


	void Start () 
	{
	
	}
	
	void Update () 
	{
		interval += Time.deltaTime;
		if(interval > intervalMax)
		{
			/* 5마리 만든다??
			GameObject obj1 = Instantiate(enemy) as GameObject
			GameObject obj2 = Instantiate(enemy) as GameObject
			GameObject obj3 = Instantiate(enemy) as GameObject
			GameObject obj4 = Instantiate(enemy) as GameObject
			GameObject obj5 = Instantiate(enemy) as GameObject
			*/

			for(int i = 0;i < 5; i++)
			{
				GameObject obj = Instantiate(enemy) as GameObject
				obj.transform.ImagePosition = 
			}
			interval = 0;
		}
	}
}
