using UnityEngine;
using System.Collections;

public class ClearArea : MonoBehaviour {
	public float timeSinceLastTrigger = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastTrigger += Time.deltaTime;
		/*if(triggerfix){
			HandleCollision();
		}*/
		if (timeSinceLastTrigger >1f && Time.realtimeSinceStartup > 10f){
			SendMessageUpwards("OnFindClearArea");
		}
	}
	
	/*#region test
	void OnTriggerExit ()
	{
		triggerfix = false;
	}

	void OnTriggerEnter ()
	{
		triggerfix = true;

	}

	void HandleCollision ()
	{
		timeSinceLastTrigger = 0f;
		print ("FA");
	}
	#endregion*/
	
	void OnTriggerStay(){
		timeSinceLastTrigger = 0f;
	}
	
}
