using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour {

	public Transform target = null;
	public Vector3 myPos;
	
	// Use this for initialization
	void Start () {
		//myPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.position + myPos; 
		
	}
}
