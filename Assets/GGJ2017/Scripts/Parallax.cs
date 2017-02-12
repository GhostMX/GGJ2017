using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {
    public Transform[] myBackGrounds;
    private float[] parallaxScales;
    public float Smoothing;
    private Vector3 previousCameraPosition;
	// Use this for initialization
	void Start () {
        previousCameraPosition = transform.position;
        parallaxScales = new float[myBackGrounds.Length];
        for(int i = 0;i< parallaxScales.Length;i++){
            parallaxScales[i] = myBackGrounds[i].position.z * -1;
        }}
	
	// Update is called once per frame
	void LateUpdate () {
        for (int i = 0; i < myBackGrounds.Length; i++){
            Vector3 parallax = (previousCameraPosition - transform.position) * (parallaxScales[i] / Smoothing);
            myBackGrounds[i].position = new Vector3(myBackGrounds[i].position.x + parallax.x, myBackGrounds[i].position.y + parallax.y, myBackGrounds[i].position.z + parallax.z);
        }
        previousCameraPosition = transform.position;
	}
}
