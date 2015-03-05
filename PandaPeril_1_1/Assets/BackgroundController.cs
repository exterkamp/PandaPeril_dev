using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	public GameObject spawner;

	public float baseSpeed = 0.025f;
	public float maxSpeed = 0.1f;
	//public float maxSpeedVariation = 0.2f;
	
	public float acceleration = 0.0025f;
	public float deceleration = 0.025f;
	
	public float curSpeed;
	public bool  stopFlag;

	public GameObject[] prefab;
	public float yMax;
	public float yMin;
	public float chanceOfSpawnPerUpdate;
	private GameObject terrainControllerRef;

	// Use this for initialization
	void Start () {
		curSpeed = baseSpeed;
		stopFlag = false;
		terrainControllerRef = GameObject.FindGameObjectWithTag ("BGController");
		//StartCoroutine (spawnBG());
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!Input.GetMouseButton (0)) {
			stopFlag = false;
			//panda.transform.Rotate (0, 0, curRotation * Time.deltaTime);
			foreach (Transform child in transform) {
				//child is your child transform
				child.position = new Vector3 (child.position.x - curSpeed, child.position.y, 10);
			}
			if (curSpeed < maxSpeed){
				curSpeed = curSpeed + acceleration;
				//curRotation = curRotation + rotationAcc;
			}
			else if (curSpeed > maxSpeed){
				curSpeed = maxSpeed;
			}
			if (Random.Range(0f,1f) <= chanceOfSpawnPerUpdate)
			{
				//spawnBG ();
				Vector3 newPos = new Vector3 (spawner.transform.position.x, spawner.transform.position.y + Random.Range (yMin, yMax), spawner.transform.position.z);
				
				GameObject newBG = (GameObject)Instantiate (prefab [Random.Range (0, prefab.Length)], newPos, new Quaternion (0, 0, 0, 0));
				
				newBG.transform.parent = terrainControllerRef.transform;
			}
		} else {
			if (!stopFlag)
			{
				//panda.transform.Rotate (0, 0, curRotation * Time.deltaTime);
				foreach (Transform child in transform) {
					//child is your child transform
					child.position = new Vector3 (child.position.x - curSpeed, child.position.y, 10);
				}
				//panda.transform.position = transform.position + new Vector3 (curSpeed, 0.0f, 0.0f);
			}
			if (curSpeed > 0 && !stopFlag){
				//curRotation -= rotationDec;
				curSpeed -= deceleration;
			}
			else{
				curSpeed = baseSpeed;
				//curRotation = baseRotation;
				stopFlag = true;
			}
			
			
			//curSpeed = baseSpeed;
			//curRotation = baseRotation;
		}
		
	}

	/*IEnumerator spawnBG(){
		//choose postion
		while (true) {
			Vector3 newPos = new Vector3 (this.transform.position.x, this.transform.position.y + Random.Range (yMin, yMax), this.transform.position.z);

			GameObject newBG = (GameObject)Instantiate (prefab [Random.Range (0, prefab.Length)], newPos, new Quaternion (0, 0, 0, 0));

			newBG.transform.parent = terrainControllerRef.transform;
		}
		//return Start ();
	}*/

}
