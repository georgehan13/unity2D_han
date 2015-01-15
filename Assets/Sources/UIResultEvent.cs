using UnityEngine;
using System.Collections;

public class UIResultEvent : MonoBehaviour 
{
	public UILabel bestScoreLabel = null;
	public UILabel scoreLabel = null;

	public void Retry()
	{
		Application.LoadLevel("Game");
	}

	public void ToTitle()
	{
		Application.LoadLevel("Title");
	}
}
