using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour
{
	[SerializeField]
	private Chain chain;

	void OnTriggerEnter2D(Collider2D col)
	{
		Chain.IsFired = false;

		if (col.tag == "ball")
		{
			col.GetComponent<Ball>().Split();
		}
	}
}
