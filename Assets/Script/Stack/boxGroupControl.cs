﻿using UnityEngine;
using System.Collections;

public class boxGroupControl : MonoBehaviour {
	public static int boxCount;
	public int boxCounting;
	public bool _isBoxEmpty;
	public projectile[] boxFruit;
	// Use this for initialization
	void Start () {
		_isBoxEmpty = false;
		boxCounting = boxFruit.Length;
		boxCount = boxCounting;
	}
	
	// Update is called once per frame
	void Update () {
		//กล่อองสุดท้าย จะอยู่อันแรก
		//กล่องแรกที่จะโยน จะเอาไปไว้อันสุดท้ายของอาเรย์
		if(boxCount>0)
		{boxFruit [boxCount-1].isEnableToDrag = true;}
		if (boxCount <= 0) {
			if(boxFruit [boxCount].GetComponent <projectile> ().getBoxChecked ())
			_isBoxEmpty = true;
		}
//		Debug.Log ("Now box = "+boxCount);
	}
}
