using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputListener : MonoBehaviour {

	Text textObject;
	string newText;

	void Start () {
		textObject = this.GetComponent<ManagerScript>().textObject;	
	}
	

	void Update () {
		//check number keys

		for(int i = 0; i < 10; i++) {
			if(Input.GetKeyDown(""+i)){
				newText = textObject.text + i;
			}
		}

		//backspace
		if(Input.GetKeyDown(KeyCode.Backspace) && textObject.text.Length >= 1){
			newText = textObject.text.Substring(0,textObject.text.Length - 1);
		}

		//Enter
		if(Input.GetKeyDown(KeyCode.Return) && textObject.text.Length == 9){
			this.GetComponent<ManagerScript>().AddToList();
			textObject.text = null;
			newText = null;
		}

		if(newText != null && newText.Length < 10)
		textObject.text = newText;
	}
}
