using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public static GameManager gm;

	public int Score = 0;
	public Text ScoreText;

	public float Timer = 10.0f;
	public Text TimerText;

	public int VictoryScore = 5;
	public Canvas VictoryCanvas;
	public Canvas GameplayCanvas;

	void Awake()
	{
		gm = this;
		VictoryCanvas.enabled = false;
		GameplayCanvas.enabled = true;
	}

	void Update()
	{
		ChangeTimer (-Time.deltaTime);
	}

	public void PrintName()
	{
		Debug.Log (gameObject.name);
	}

	public void AddScore(int amount)
	{
		Score += amount;
		ScoreText.text = "x " + Score.ToString();

		if (Score >= VictoryScore) 
		{
			//moze kontrolirat vrijeme,novcice,itd.
			//Debug.Log ("Victory!");
			//VictoryCanvas.enabled = true;
			//GameplayCanvas.enabled = false;
		}
	}

	public void ChangeTimer(float amount)
	{
		Timer += amount;
		TimerText.text = "Timer: " + Timer.ToString ();
	}



}

