﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

//	public string SceneName;

	// Use this for initialization
	void Start () {

	}

	public void ToScene(string Scenename){
		
		SceneManager.LoadScene(Scenename);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}