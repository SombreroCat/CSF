using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StudentAttendance : MonoBehaviour {
	DirectoryInfo dir;
	public Text StudentID;
	public Text ReturnStatement;
	FileInfo[] meetings;
	string MeetingsAttended;
	float attendance = 0;
	void Start () {
		dir = new DirectoryInfo (@".\Meetings\");
		meetings = dir.GetFiles ();
	}
	
	//goes through all the meetings and counts the amount of times the longID is shown
	public void CheckAttendance () {
		if (meetings.Length > 0) {
			for (int i = 0; i < meetings.Length; i++) {
				string[] info = System.IO.File.ReadAllLines (meetings [i].FullName);
				for (int a = 0; a < info.Length; a++) {
					if (StudentID.text.Equals (info [a])) {
						attendance++;
					}
				}
			}
			MeetingsAttended = StudentID.text + " has attended " + attendance + " meeting(s)";
		} else {
			MeetingsAttended = "No meetings exist, check meetings folder";
		}
		printStudentValue ();
	}
	//changes the text to show the amount of meets that studentID has attended
	void printStudentValue(){
		ReturnStatement.text = MeetingsAttended;
	}
	//returns to Menu
	public void ReturnMenu(){
		SceneManager.LoadScene (0);
	}
}
