﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Stack_Controll : MonoBehaviour {
	public bubble_ui bui;

	public boxGroupControl boxGroup;
	public int scoreWhenFall=10;
	public int scoreWhenCarry = 10;
	//check this if stage is tutorial
	public bool isTutorial = false;
	public boxbomb[] boxbomb;
	private bool isBombed;
	public int boxbombLen;
	public int boxbombCounter;



	static public int stackScore;

	private string[] boxTag = new string[]{"BoxFruit"};
	// Use this for initialization
	void Start () {
		
		//static score for stack
		stackScore = 0;
		boxGroup._isBoxEmpty = false;
		isBombed = false;

		boxbombLen = boxbomb.Length;
		boxbombCounter = 0;
	}

	// Update is called once per frame
	void Update () {
		
//		Debug.Log ("BB LEN = "+boxbombLen);
		for (int i = 0; i < boxbombLen; i++) {
//			Debug.Log ("boxbomed is true ?");
			if (boxbomb [i]._isBombed) {
				isBombed = true;
//				Debug.Log ("isTRUE BOMBED !!!");
			}
		}
		if (bui.isGameUIOver|| boxGroup._isBoxEmpty || isBombed) {
			boxGroup._isBoxEmpty = true;
			isBombed = true;
			bui.isGameUIOver = true;

			//active the Gameover Canvas

		}
		if (!isTutorial) {
			
		}
	}



	void OnTriggerEnter2D(Collider2D other)
	{
		if (isBombed) {
			return;
		}
		foreach(string a in boxTag){
			if(other.tag == a)
			{ 
//				stackScore -= scoreWhenFall;
				if (stackScore < 0) {
					stackScore = 0;
				}
//				Debug.Log ("is In ur foot");
			}
		}
		if(other.tag ==  "BoxBomb" ){

			if (boxbombCounter < boxbombLen) {
				bui.incScore (scoreWhenCarry);
				boxbomb [boxbombCounter]._isStop = true;
				boxbombCounter++;
			} else {
//				Debug.Log ("BOOM");
			}
//			Debug.Log("STACK -> boxbombLen= "+ boxbombLen +" boxbombCounter = "+ boxbombCounter);
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (isBombed) {
			return;
		}
		if(other.tag ==  "BoxBomb" ){
			bui.incScore (-scoreWhenCarry);
			boxbombCounter--;
			boxbomb [boxbombCounter]._isStop = false;
//			Debug.Log("STACK 2 -> boxbombLen= "+ boxbombLen +" boxbombCounter = "+ boxbombCounter);
		}
	}
		
}
