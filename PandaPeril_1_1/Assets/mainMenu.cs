using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	private void OnGUI(){
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2-50,200,100), "Play"))
		{
		    Application.LoadLevel("MainScene");
		}
	}
}
