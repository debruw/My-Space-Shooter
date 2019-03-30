using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour 
{
	// Destroy everything that enters the trigger
    void OnTriggerEnter(Collider other)
    {
		if(other.tag == "Boundry")
		{
			return;
		}
        Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
