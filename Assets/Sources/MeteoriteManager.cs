using UnityEngine;
using System.Collections;

public class MeteoriteManager : MonoBehaviour 
{

	void Start () 
	{
		//StartCoroutine(Call ());

		IEnumerator e = Call2();
		while(e.MoveNext())
		{
			print(e.Current);
		}
	}

	IEnumerator Call2()
	{
		yield return 1;

		yield return "kim";

		yield return 0.1f;
	}


	/*
	IEnumerator Call()
	{
		yield return new WaitForSeconds(3);

		print("Call !!!!!");

		yield return new WaitForSeconds(2);
		
		print("Call2 !!!!!");

		yield return new WaitForSeconds(1);
		
		print("Call3 !!!!!");

	}
	*/
}
