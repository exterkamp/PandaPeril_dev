using UnityEngine;
using System.Collections;

public class garbageCollect : MonoBehaviour {

	public GameObject[] prefab;
	private GameObject terrainControllerRef;

	//public boolean collision
	// Use this for initialization
	void Start () {
		terrainControllerRef = GameObject.FindGameObjectWithTag ("TerrainController");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collidee)
	{
		if (!collidee.gameObject.transform.parent.tag.Equals ("BGItem")) {


			//Rigidbody newTerrain;

			Transform farthestRight = null;
			foreach (Transform child in terrainControllerRef.transform) {
				if (farthestRight != null) {
					if (farthestRight.position.x < child.position.x) {
						farthestRight = child;
					}
				} else {
					farthestRight = child;
				}
			}

			Vector3 newPos = new Vector3 (farthestRight.position.x + 50, 0, 0);


			//Rigidbody newTerrain; 
			GameObject newTerrain = (GameObject)Instantiate (prefab [Random.Range (0, prefab.Length)], newPos, new Quaternion (0, 0, 0, 0));
			//Instantiate (obj [Random.Range (0, obj.GetLength (0))], transform.position, Quaternion.identity);



			newTerrain.transform.parent = terrainControllerRef.transform;
			//SpriteRenderer sr = (SpriteRenderer)newTerrain.GetComponent<SpriteRenderer> ();
			//sr.color = new Color (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f),1f);
			//GameObject gO = clone.gameObject;
			//SpriteRenderer[] sr = gO.GetComponents<SpriteRenderer>();
			//if (sr != null) {
			//	sr[0].color = new Color (Random.Range (0, 255), Random.Range (0, 255), Random.Range (0, 255));
			//}
			//Random rand = new Random ();
		}
		Destroy (collidee.gameObject.transform.parent.gameObject);
	}
}
