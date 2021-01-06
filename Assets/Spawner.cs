using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public int nbInstances = 1;
	public GameObject prefab;

	void Start()
	{
		for (int i = 0; i < nbInstances; i++)
		{
			Instantiate(prefab);
		}
	}
}
