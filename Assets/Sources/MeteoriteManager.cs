using UnityEngine;
using System.Collections;

public class MeteoriteManager : MonoBehaviour 
{

	void Start () 
	{
		StartCoroutine(Call ());
	}

	IEnumerator Call()
	{
		yield return new WaitForSeconds(3);

		print("Call !!!!!");
	}
}
