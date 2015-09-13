using UnityEngine;
using System.Collections;

public class Level_Manager : MonoBehaviour {

	void Start(){
		
		Debug.Log ("Hello");
	}
	
	public void LoadLevel(string name){
		Debug.Log("Level load requested for: "+name);
		Application.LoadLevel (name);
	}
	
	public void QuitRequest(){
		Application.Quit ();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
}
