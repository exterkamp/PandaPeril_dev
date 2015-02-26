using UnityEngine;
using System.Collections;

public class terrainControlScript : MonoBehaviour {

	public GameObject panda;


	public float baseSpeed = 0.05f;
	public float baseRotation = -180f;
	public float maxSpeed = 0.25f;

	public float acceleration = 0.005f;
	public float deceleration = 0.025f;

	public float rotationAcc = -1f;
	public float rotationDec = 5f;

	public float curSpeed;
	public float curRotation;
	public bool  stopFlag;
	// Use this for initialization
	void Start () {
		curSpeed = baseSpeed;
		curRotation = baseRotation;
		stopFlag = false;
		panda = GameObject.FindGameObjectWithTag ("Panda");
	}
	
	// Update is called once per frame
	void Update () {
		if (!Input.GetMouseButton (0)) {
			stopFlag = false;
			panda.transform.Rotate (0, 0, curRotation * Time.deltaTime);
			foreach (Transform child in transform) {
				//child is your child transform
				child.position = new Vector3 (child.position.x - curSpeed, child.position.y, 0);
			}
			if (curSpeed < maxSpeed){
				curSpeed = curSpeed + acceleration;
				curRotation = curRotation + rotationAcc;
			}
			else if (curSpeed > maxSpeed){
				curSpeed = maxSpeed;
			}
		} else {
			if (!stopFlag)
			{
				panda.transform.Rotate (0, 0, curRotation * Time.deltaTime);
				foreach (Transform child in transform) {
					//child is your child transform
					child.position = new Vector3 (child.position.x - curSpeed, child.position.y, 0);
				}
				//panda.transform.position = transform.position + new Vector3 (curSpeed, 0.0f, 0.0f);
			}
			if (curSpeed > 0 && !stopFlag){
				curRotation -= rotationDec;
				curSpeed -= deceleration;
			}
			else{
				curSpeed = baseSpeed;
				curRotation = baseRotation;
				stopFlag = true;
			}


			//curSpeed = baseSpeed;
			//curRotation = baseRotation;
		}

	}
}
