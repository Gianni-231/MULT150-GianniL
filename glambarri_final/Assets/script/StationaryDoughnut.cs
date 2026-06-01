using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryDoughnut : MonoBehaviour
{
	 private AudioSource audioSource;
	void Start()
{
    audioSource = GetComponent<AudioSource>();
}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("Doughnut collected!");
			audioSource.Play();
			 GetComponent<Collider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;

        Destroy(gameObject, audioSource.clip.length);
            
		}
	}
}
