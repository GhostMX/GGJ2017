using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colocacao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void InicioGameScene(){
		SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
	}
	public void QuitGameScene(){
		Application.Quit ();
	}
}
