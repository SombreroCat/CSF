using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataHolder : MonoBehaviour {

	public string MeetingName;

	public List<string> finishedList;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
	}
	
	public void writeOut(){

		//name of the text document
		string pathString = @".\Meetings\" + MeetingName + ".txt";

//		if (!System.IO.File.Exists(pathString))
//		System.IO.File.CreateText (pathString);

		//fills text
		System.IO.StreamWriter file = System.IO.File.CreateText (pathString);
		for (int i = 0; i < finishedList.Count; i++) {
			file.WriteLine (finishedList[i]);
		}
		file.Close();
	}



}
