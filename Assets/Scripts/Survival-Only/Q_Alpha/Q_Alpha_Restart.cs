﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q_Alpha_Restart : MonoBehaviour {

	public Canvas canvas;
	public ControleDeFases controle;

	void OnMouseDown(){
		canvas.gameObject.SetActive (true);
		controle.onPause ();
		Time.timeScale = 0;
	}

}
