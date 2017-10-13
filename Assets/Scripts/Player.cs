using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Player : MonoBehaviour 
{
	private bool invincible = false;

	public int Health;
	public int maxHealth = 5;


	void Start()
	{
		Health = maxHealth;
	}

	void Awake()
	{

		//LoadHealth ();
		//SaveHealth ();
	}

	void Update()
	{
		if (Health > maxHealth) 
		{
			Health = maxHealth;
		}

		if (Health <= 0) 
		{
			Die ();
		}
	}

	public void Damage (int dmg)
	{
		Health -= dmg;
	}

	IEnumerator OnTriggerEnter2D(Collider2D col)
	{
		if (!invincible)
		{
			if (col.gameObject.tag == "Enemy") 
			{
				GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
				if(playerObject != null)
				{
					gameObject.GetComponent<EnemyDMG>();
				}

				invincible = true;
				yield return new WaitForSeconds (2);
				invincible = false;


			}
		}
	}


	/*public void SaveHealth()
	{
		PlayerPrefs.SetInt ("Health", Health);
		Debug.Log ("Health Saved: " + Health.ToString ());
	}

	public void LoadHealth()
	{
		Health = PlayerPrefs.GetInt ("Health", 10);
		Debug.Log ("Health Loaded: " + Health.ToString ());
	}
  */
	void Die()
	{
		Application.LoadLevel (Application.loadedLevel);
	}


}

/*#if UNITY_EDITOR
[CustomEditor(typeof(Player))]
public class PlayerEditor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector ();

		Player player = (Player)target;

		if (GUILayout.Button ("Save Health"))
			player.SaveHealth ();

		if (GUILayout.Button ("Load Health"))
			player.LoadHealth ();
	}

}
#endif
*/