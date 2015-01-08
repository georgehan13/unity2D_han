using UnityEngine;
using System.Collections;

public class MeteoriteManager : MonoBehaviour 
{
	public GameObject alarm = null;
	public GameObject meteorite = null;
	public GameObject tail = null;


	void Start () 
	{
		StartCoroutine(Call ());

		/*
		IEnumerator e = Call2();
		while(e.MoveNext())
		{
			print(e.Current);
		}
		*/
	}




	IEnumerator Call()
	{
		float time = Random.Range (2.0f, 5.0f);

		yield return new WaitForSeconds(time);

		GameObject alarmObj = Instantiate(alarm) as GameObject;
		alarmObj.transform.position = this.transform.position;

		float length = alarmObj.animation["Alarm"].length;
		yield return new WaitForSeconds(length);

		Destroy(alarmObj);

	}

	/*
	IEnumerator Call2()
	{
		yield return 1;
		
		yield return "kim";
		
		yield return 0.1f;
	}
	*/
}
