using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float ammoSpeed = 3.0f;
	public float ammoStrength = 0.01f;
	// Use this for initialization
	void OnCollisionEnter (Collision collision) 
	{
		Target target = collision.gameObject.GetComponent<Target> ();
		target.Hit (ammoStrength);
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Vector3.forward * ammoSpeed * Time.deltaTime, Space.Self);	
	}
}
