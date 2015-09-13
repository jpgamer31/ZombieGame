using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {
	private AudioSource audioSource;
	private bool called = false;
	public AudioClip callSound;
	
	private Rigidbody rigidBody;
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		rigidBody = GetComponent<Rigidbody>();
	}
	

	
	public void Call() { 
		if(! called){
		if(Input.GetButtonDown ("CallHeli")){
			called = true;
			audioSource.clip = callSound;
			audioSource.Play();
			rigidBody.velocity = new Vector3 (0,0,50f);
		}
	}
	}
}
