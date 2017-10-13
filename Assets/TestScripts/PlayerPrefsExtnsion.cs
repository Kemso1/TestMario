using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerPrefsExtnsion 
{
	public static void SaveStats(Stats stats)
	{
		PlayerPrefs.SetInt ("Armor", stats.Armor);
		PlayerPrefs.SetInt ("Health", stats.Health);
	}

	public static Stats LoadStats()
	{
		int armor = PlayerPrefs.GetInt ("Armor", 0);
		int health = PlayerPrefs.GetInt ("Health", 50);

		Stats stats = new Stats (armor, health);

		return stats;
	}
}
