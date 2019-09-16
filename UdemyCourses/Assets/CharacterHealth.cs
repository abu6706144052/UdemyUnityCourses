using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterHealth : MonoBehaviour
{
	[SerializeField]
	private GameObject charPrefab;

	[SerializeField]
	private float respawnTime = 5f;

	private float nextSpawnTime;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
		if(Time.time >= nextSpawnTime)
		{
			nextSpawnTime = Time.time + respawnTime;

			GameObject.Instantiate(charPrefab, transform.position, transform.rotation);
		}
    }
}
