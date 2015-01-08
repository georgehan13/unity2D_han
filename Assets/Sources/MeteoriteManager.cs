using UnityEngine;
using System.Collections;

public class MeteoriteManager : MonoBehaviour 
{
	public GameObject alarm = null;
	public GameObject meteorite = null;
	public GameObject tail = null;
	public Transform alarmPosition = null;


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
		alarmObj.transform.position = alarmPosition.position; //this.transform.position;

		float length = alarmObj.animation["Alarm"].length;
		yield return new WaitForSeconds(length);

		Destroy(alarmObj);

		GameObject meteoriteObj = Instantiate(meteorite) as GameObject;
		meteoriteObj.transform.position = this.transform.position;

		GameObject tailObj = Instantiate(tail) as GameObject;
		tailObj.transform.position = this.transform.position;
		tailObj.renderer.sortingLayerName = "Tail";
		tailObj.transform.parent = meteoriteObj.transform;

		StartCoroutine(Call ());

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
