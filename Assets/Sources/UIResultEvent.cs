using UnityEngine;
using System.Collections;

public class UIResultEvent : MonoBehaviour 
{
	public void Retry()
	{
		Application.LoadLevel("Game");
	}

	public void ToTitle()
	{
		Application.LoadLevel("Title");
	}
}
