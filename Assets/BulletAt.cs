﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAt : MonoBehaviour {

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.collider.CompareTag("Player"))
		{
			Destroy(collision.gameObject);
		}
	}
		

}
