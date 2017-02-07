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
        //mycam.orthographicSize = (Screen.height / 100f) / 0.5f;
        if ( target)
        {
             transform.position = Vector3.Lerp (transform.position, target.position, 0.1f) + new Vector3(0,0, -10);
        //    transform.position = new Vector3(target.position.x, 3.7f, -10);
            //1.7
        }
		/*if (Playerinput.LandingState==true) {

            this.enabled = false;
            Debug.Log ("Camera is ready");
                
			
		}*/

        
	}
}
