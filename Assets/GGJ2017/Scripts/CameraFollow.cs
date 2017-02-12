using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public Transform target;
    Camera mycam;
	private GameObject Player;
	PlayerInputController Playerinput;

    // Use this for initialization
    void Start () {
        mycam = GetComponent<Camera>();
		Player = GameObject.FindGameObjectWithTag ("Player");
		Playerinput = Player.GetComponent<PlayerInputController> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (target){
             transform.position = Vector3.Lerp (transform.position, target.position, 0.1f) + new Vector3(0,0, -10);
        }
	}
}
