using UnityEngine;
using System.Collections;

public class UIResultEvent : MonoBehaviour 
{
	public UILabel bestScoreLabel = null;
	public UILabel scoreLabel = null;

	void Start()
	{
		int score = PlayerPrefs.GetInt ("Score",0);
		int bestScore = PlayerPrefs.GetInt ("BestScore",0);

		if(score > bestScore)
		{
			bestScore = score;
			PlayerPrefs.SetInt ("BestScore", bestScore);
		}

		bestScoreLabel.text = "BestScore : " + bestScore;
		scoreLabel.text = "Score : " + score;
	}

	public void Retry()
	{
		Application.LoadLevel("Game");
	}

	public void ToTitle()
	{
		Application.LoadLevel("Title");
	}
}
