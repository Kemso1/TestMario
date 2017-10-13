using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDMG : MonoBehaviour 
{

	private Player _player;

	void Start()
	{
		GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
		if(playerObject != null)
		{
			_player = playerObject.GetComponent<Player>();
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Player"))
		{
			_player.Damage (1);
		}
	}



}
