using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour {

	[Tooltip ("one real life second = one game minute")]
	public float mps;
	private Quaternion startRotation;
	
	void Start(){
		startRotation = transform.rotation;
	}
	
		void Update(){
		float angleThisFrame = Time.deltaTime/360 * mps;
			transform.RotateAround(transform.position, Vector3.forward,angleThisFrame);
		}
	
	}
