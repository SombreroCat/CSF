using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputListenerField : MonoBehaviour {
	public Text textObject;
	public GameObject InputField;
	public GameObject notLongEnough;
	private bool alert = false;

	//Submits the text entered into the file
	void Update(){
		notLongEnough.gameObject.SetActive (alert);
	}
	public void EnteredText () {
	//if text is long as 9, enters it into list if not, activates alert	
		if (textObject.text.Length == 9) {
			this.GetComponent<ManagerScript> ().AddToList ();
			textObject.text = null;
			InputField.GetComponent<InputField> ().text = null;
		} else {
			alert = true;
			AlertTimer ();
		}
	}
	void AlertTimer(){
		StartCoroutine(AlertDisappear (1));
	}
	//cooldown before alert dissapears
	IEnumerator AlertDisappear(int waitTime){
		Debug.Log ("I have been called");
		yield return new WaitForSeconds(waitTime);
		alert = false;
		Debug.Log ("I have finished");
	}
}
