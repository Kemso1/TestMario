using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Player1 : MonoBehaviour
{
	public enum SaveLoadSystemType
	{
		PlayerPrefs,
		Binary,
		XML
	}

	public SaveLoadSystemType SLSType = SaveLoadSystemType.PlayerPrefs;
	public Stats PlayerStats;

	void Awake()
	{
		//DontDestroyOnLoad (gameObject);

		//Application.LoadLevel (1);
	}

	public void SavePlayerStats()
	{
		switch (SLSType) 
		{
		case SaveLoadSystemType.PlayerPrefs:
			PlayerPrefsExtnsion.SaveStats (PlayerStats);
			break;

		case SaveLoadSystemType.Binary:
			BinarySerializer.SaveStats (PlayerStats);
			break;

		case SaveLoadSystemType.XML:
			XML.SaveStats (PlayerStats);
			break;
		}
	}

	public void LoadPlayerStats()
	{
		switch (SLSType) 
		{
		case SaveLoadSystemType.PlayerPrefs:
			PlayerStats = PlayerPrefsExtnsion.LoadStats ();
			break;

		case SaveLoadSystemType.Binary:
			PlayerStats = BinarySerializer.LoadStats ();
			break;

		case SaveLoadSystemType.XML:
			PlayerStats = XML.LoadStats ();
			break;
		}
	}

}

#if UNITY_EDITOR

[CustomEditor(typeof(Player1))]
public class Player1Editor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector ();

		Player1 player = (Player1)target;

		if (GUILayout.Button ("Save"))
			player.SavePlayerStats ();

		if (GUILayout.Button ("Load"))
			player.LoadPlayerStats ();
	}

}
#endif
