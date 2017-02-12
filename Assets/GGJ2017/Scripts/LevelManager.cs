using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public static LevelManager instance = null;

    public Vector3 currentCheckPoint;
	//public GameObject currentCheckPoint;
    public GameObject player;

	void Awake(){
		//Check if instance already exists
		if (instance == null) {

			//Sets this to not be destroyed when reloading scene
			DontDestroyOnLoad (gameObject);

			//if not, set instance to this
			instance = this;

			//If instance already exists and it's not this:
		} else if (instance != this) {

			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy (gameObject);    

		}
	}


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
        
    
	}
    public void RespawnPlayer(){
        player.transform.position = currentCheckPoint;
    }

}
