using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class BinarySerializer 
{
	public static void SaveStats(Stats stats)
	{
		string path = Application.persistentDataPath + "/PlayerStats.dat";

		FileStream file = File.Create (path);
		BinaryFormatter bf = new BinaryFormatter ();

		bf.Serialize (file, stats);
		file.Close ();

		Debug.Log ("BinarySerializer: - Save - " + path);
	}

	public static Stats LoadStats()
	{
		string path = Application.persistentDataPath + "/PlayerStats.dat";

		if (File.Exists (path)) 
		{
			FileStream file = File.Open (path, FileMode.Open);
			BinaryFormatter bf = new BinaryFormatter ();

			Stats stats = (Stats)bf.Deserialize (file);
			file.Close ();

			Debug.Log ("BinarySerializer : - Load - " + path);
			return stats;
		}

		Debug.LogWarning ("No data file: " + path);
		return null;
    }
}
