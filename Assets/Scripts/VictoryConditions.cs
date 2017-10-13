using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryConditions : MonoBehaviour 
{
	private Animator _animator;

	void Awake()
	{
		_animator = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			_animator.SetBool ("IsVictory", true);
			Invoke ("TriggerVictory", 2);
	}


	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			_animator.SetBool ("IsVictory", false);
	}

	private void TriggerVictory()
	{

		Application.LoadLevel ("Sandbox2");

	}

}
