using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public Transform target;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (target){
             transform.position = Vector3.Lerp (transform.position, target.position, 0.1f) + new Vector3(0,0, -10);
        }
	}
}
