using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour 
{
	public Sprite[] HeartSprites;

	public Image HeartUI;

	//private GameObject player;
	private Player _player;

	void Start()
	{
		GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
			if(playerObject != null)
			{
				_player = playerObject.GetComponent<Player>();
			}
		//player = GameObject.FindGameObjectWithTag ("Player");
	    //GetComponent<Player> ();
	}

	void Update()
	{
		HeartUI.sprite = HeartSprites[_player.Health];
	}
}
