using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour {

	public List<string> IDList;

	public Text textObject;

	public GameObject data;
	public GameObject created;


	void Start(){
		data = GameObject.Find ("MeetingData");
	}

	//if not apart of the id list already, the id is added to the list
	public void AddToList(){
		if (!IDList.Contains (textObject.text)) { 
			IDList.Add (textObject.text);
		} else {
			print ("ID already logged");
		}
	}

	public void sendList()
	{
		//places the finished list as the IDList gathered
		data.GetComponent<DataHolder> ().finishedList = IDList;	
		//calls method to create the text document
		data.GetComponent<DataHolder> ().writeOut ();
		created.SetActive (true);
	}
	public void returnMenu(){
		//loads in menu screen
		SceneManager.LoadScene(0);
	}
}
