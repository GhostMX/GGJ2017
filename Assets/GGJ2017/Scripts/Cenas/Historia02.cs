using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Historia02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadGameScene(){
		SceneManager.LoadScene ("Cena01", LoadSceneMode.Single);
	}
	public void NovaHGameScene(){
		SceneManager.LoadScene ("Cena01", LoadSceneMode.Single);
	}
}
