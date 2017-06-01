using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DateInput : MonoBehaviour {

	public Text textObject;
	string Date;

	public GameObject MeetingHolder;	//gameobject is named MeetingData in scene

	void Start () {
		Date = "" + System.DateTime.Now.ToString("MM-dd-yyyy");	//gets the current date
		textObject.text = Date;
	}

	public void CreateMeeting(){
		//sets the date on the meeting and the name of text file
		MeetingHolder.GetComponent<DataHolder>().MeetingName = Date;	
		//loads the inputScreen scene
		SceneManager.LoadScene(2);
	}

	public void ReturnMenu(){
		SceneManager.LoadScene (0);
	}
}
