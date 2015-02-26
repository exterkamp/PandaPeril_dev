using UnityEngine;
using System.Collections;

public class lightController : MonoBehaviour {

	protected Animator animator;

	//private bool onFlagLocal;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		//onFlagLocal = animator.GetBool ("onFlag");
		StartCoroutine (Flicker ());
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator Flicker()
	{
		while (true) {
			/*AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo (0);
			
			if (stateInfo.nameHash == Animator.StringToHash ("Base Layer.off")) {
				
			}*/
			//onFlagLocal = !onFlagLocal;
			animator.SetBool("onFlag", !animator.GetBool ("onFlag"));

			if (animator.GetBool("onFlag") == true){
				yield return new WaitForSeconds(Random.Range(0.1f,0.9f));
			}
			else{
				yield return new WaitForSeconds(1);
			}
			/*
			AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo (0);
			
			if (stateInfo.nameHash == Animator.StringToHash ("Base Layer.on") && animator.GetBool("onFlag") == true) {
				//make it a random amount of time
				yield return new WaitForSeconds(Random.Range(0.1f,0.2f));

			}
			else if (stateInfo.nameHash == Animator.StringToHash ("Base Layer.off")){
				yield return new WaitForSeconds(1);
			}
			else{
				yield return new WaitForSeconds(1);
			}*/


		}
	}
}
