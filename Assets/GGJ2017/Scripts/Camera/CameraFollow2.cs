/*using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public Transform target;

	public Camera mycam;
	public bool Ativar;
	public int CamTrigger;

	public float StopInicial;
	public float StopFinal;

	private bool pararSom;

	AudioSource audioComponente;

	public Transform StoppedCam;
	// Use this for initialization
	void Start () {
		mycam = GetComponent<Camera> ();
		audioComponente = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		//mycam.orthographicSize = (Screen.height / 100f) / 0.5f;
		//pararSom = GameManager.instance.GetMudo();

		if (pararSom) {
			audioComponente.mute = true;
		} else {
			audioComponente.mute = false;
		}

		if (target) {
			if (Ativar) {
				transform.position = Vector3.Lerp (transform.position, target.position, 1f) + new Vector3 (0, +0.5f, -10);
			} else {
				if (CamTrigger == 1) {	
					transform.position = Vector3.Lerp (transform.position, new Vector3 (StopInicial, target.transform.position.y, target.transform.position.z), 1f) + new Vector3 (0, +0.5f, -10);
				} else if (CamTrigger == 2) {
					transform.position = Vector3.Lerp (transform.position, new Vector3 (StopFinal, target.transform.position.y, target.transform.position.z), 1f) + new Vector3 (0, +0.5f, -10);
				} else {
					transform.position = Vector3.Lerp (transform.position, target.position, 1f) + new Vector3 (0, +0.5f, -10);
				}
			}
		}
	}
}
*/