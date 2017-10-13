using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour 
{
	public Transform Player;
	public Vector3 PositionOffset;

	private Transform _transform;

	void Awake()
	{
		_transform = transform;
	}
 
	void LateUpdate()
	{
		//_transform.position.y horizontal camera
		Vector3 newPosition = new Vector3 (Player.position.x, _transform.position.y, _transform.position.z) + PositionOffset;
		_transform.position = newPosition;
	}



}

