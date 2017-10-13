using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stats
{
	[Header("Read-Only")]
	[SerializeField]
	public int _armor = 0;
	[SerializeField]
	public int _health = 0;

	#region Properties
	public int Armor
	{
		get 
		{ 
			return _armor;
		}
	}

	public int Health
	{
		get 
		{ 
			return _health;
		}
	}
	#endregion

	public Stats()
	{

	}

	public Stats(int armor, int health)
	{
		_armor = armor;
		_health = health;
	}

	public void Damage(int amount)
	{
		if (amount <= 0) 
		{
			Debug.LogWarning ("Damage amount can't be a negative value!");
			return;
		}

		_armor -= amount;

		if (_armor < 0) 
		{
			_health -= _armor;
			_armor = 0;

			if (_health <= 0)
				Debug.Log ("Death.");
		}
	}
}