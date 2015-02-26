using UnityEngine;
using System.Collections;

public class PandaController : MonoBehaviour {
	
	//public float baseRotation = -90f;

	//public float curRot;

	//private bool mouseDown;
	//private bool stopFlag = false;
	// Use this for initialization
	void Start () {
		//curSpeed = baseSpeed;
		//curRot = baseRotation;
	}
	
	// Update is called once per frame
	void Update () {
		/*
		mouseDown = Input.GetMouseButton (0);

		//transform.Rotate (Vector3.right * Time.deltaTime);
		if (!mouseDown) {
			stopFlag = false;
			transform.Rotate (0, 0, curRot * Time.deltaTime);
			//transform.position = transform.position + new Vector3 (curSpeed, 0.0f, 0.0f);
			//if (curSpeed < maxSpeed)
			//{
			//	curRot -= 1f;
			//	curSpeed += 0.005f;
			//}
		} else {
			if (!stopFlag)
			{
				transform.Rotate (0, 0, curRot * Time.deltaTime);
				//transform.position = transform.position + new Vector3 (curSpeed, 0.0f, 0.0f);
			}
			//if (curSpeed > 0 && !stopFlag){
				//curRot -= 10f;
				//curSpeed -= 0.05f;
			//}
			//else{
				//curSpeed = baseSpeed;
				curRot = baseRotation;
				//stopFlag = true;
			//}
		}
	
		//transform.Rotate (Vector3.up * Time.deltaTime, Space.World);*/
	}

	void OnTriggerEnter2D(Collider2D collidee)
	{
		if (collidee.tag.Equals("Enemy")){
			Application.LoadLevel("mainMenu");
		}
		
	}

	/*void FixedUpdate () {
		if (mouseDown)
		{
			if (rigidbody2D.velocity.magnitude > 0.2)
				rigidbody2D.AddTorque (10);
			//Debug.Log ("Velocity" + rigidbody2D.velocity.magnitude);
		} else {
			rigidbody2D.AddTorque (-10);
		}
	}*/
}
