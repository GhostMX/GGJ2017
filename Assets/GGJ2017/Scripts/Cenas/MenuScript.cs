using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown){
			if (Input.GetKeyDown(KeyCode.S)){
				Debug.Log("Go to Creditos");
				LoadCredits();
			}else if (Input.GetKeyDown(KeyCode.Escape)){
				Debug.Log("Go to Exit");
				QuitGameScene();
                Application.Quit();
			}else if(Input.GetKeyDown(KeyCode.W)){
				Debug.Log("Go to Game");
				LoadGame();
			}
		}
	}
	public void LoadGame(){
		SceneManager.LoadScene ("Cena01", LoadSceneMode.Single);
	}
	public void LoadCredits(){
		SceneManager.LoadScene ("Creditos", LoadSceneMode.Single);
	}
	public void QuitGameScene(){
		Application.Quit ();
	}
}
