﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
	[SerializeField]
	private Transform player;

	[SerializeField]
	private float speed = 2f;

	public static bool IsFired;

	// Use this for initialization
	void Start()
	{
		IsFired = false;
	}

	// Update is called once per frame
	void Update()
	{

		if (IsFired)
		{
			transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
		}
		else
		{
			transform.position = player.position;
			transform.localScale = new Vector3(1f, 0f, 1f);
		}

	}


	public void Shot()
	{
		IsFired = true;
		transform.position = player.position;
		transform.localScale = new Vector3(1f, 0f, 1f);
	}
}
