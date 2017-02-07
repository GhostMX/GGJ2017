using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {
	
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (3f);
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
	
	// Update is called once per frame
	void Update () {

	}
}