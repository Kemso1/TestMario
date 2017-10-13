using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Xml.Serialization;

public static class XML
{
	public static void SaveStats(Stats stats)
	{
		string path = Application.persistentDataPath + "/PlayerStatsXML.dat";

		StreamWriter streamWriter = new StreamWriter (path);
		XmlSerializer xmlSerializer = new XmlSerializer (typeof(Stats));

		xmlSerializer.Serialize (streamWriter.BaseStream, stats);
		streamWriter.Close ();

		Debug.Log ("XML: - Save - " + path);
	}

	public static Stats LoadStats()
	{
		string path = Application.persistentDataPath + "/PlayerStatsXML.dat";

		StreamReader streamReader = new StreamReader (path);
		XmlSerializer xmlSerializer = new XmlSerializer (typeof(Stats));

		Stats stats = (Stats)xmlSerializer.Deserialize (streamReader.BaseStream);
		streamReader.Close ();

		Debug.Log ("XML - Load - " + path);

		return stats;
	}

}

