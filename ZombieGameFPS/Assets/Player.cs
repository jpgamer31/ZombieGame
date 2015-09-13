using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public AudioClip whatHappened;

	public Transform playerSpawnPoints;
	private bool reSpawn=false;
	public Helicopter helicopter;
	private Transform[] spawnPoints;
	private bool lastToggle = false;
	private bool hasNextMap = true;
	private bool hasPreviousMap=false;
	private AudioSource innerVoice;
	void Start (){
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
		
		AudioSource[] audioSources = GetComponents<AudioSource>();
		foreach(AudioSource audioSource in audioSources){
			if(audioSource.priority == 1){
				innerVoice = audioSource;
			}
		}
			innerVoice.clip = whatHappened;
			innerVoice.Play ();
	}
	
	void Update() {
		if (lastToggle != reSpawn){
			Respawn ();
			reSpawn = false;
		}else{
			lastToggle = reSpawn;
		}
		if(gameObject.transform.position.y <=45){
			Respawn();
		}
		if(Input.GetButton("AdvanceMap")){
			if(hasNextMap==true){
				Application.LoadLevel (1);
}
	}
	}
	
	void OnFindClearArea(){
		print ("Area Found in player ");
		helicopter.Call();
	}
	
	private void Respawn() {
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints[i].transform.position;
	}
}
