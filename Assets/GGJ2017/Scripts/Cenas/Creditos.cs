using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour {
	IEnumerator Start () {
		yield return new WaitForSeconds (3f);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			Debug.Log ("Go to Exit");
			QuitGameScene ();
		}else if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log("Go to Game");
			LoadGame();
		}
	}

	public void LoadGame(){
		SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
	}
	public void QuitGameScene(){
		Application.Quit ();
	}
}
