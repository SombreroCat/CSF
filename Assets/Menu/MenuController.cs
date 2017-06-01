using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	void Update(){
		if (GameObject.Find ("MeetingData")) {
			GameObject.Destroy(GameObject.Find ("MeetingData"));
		}
	}
	//loads in MeetingScript scene
	public void NewMeeting(){
		SceneManager.LoadScene (1);
	}

	//loads in FindStudent scene (not created)
	public void FindStudent(){
		SceneManager.LoadScene (3);
	}
	//closes application
	public void Exit(){
		Application.Quit();
	}

	//loads in PastMeetings scene (not created)
	public void PastMeetings(){
		SceneManager.LoadScene (4);
	}
}
