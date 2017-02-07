using UnityEngine;
using System.Collections;

public class JoyStickControler : MonoBehaviour {
	public float velocidade;
	Rigidbody2D myRigibody;

	// Use this for initialization
	void Start () {
		myRigibody = GetComponent<Rigidbody2D> ();
 
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw("RightJoystickVertical")>0.5)
		{
			myRigibody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") *-velocidade, myRigibody.velocity.y);


			}

		if (Input.GetAxisRaw ("LeftJoystickVertical") < 0.5) {
			myRigibody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * velocidade, myRigibody.velocity.y);
			transform.eulerAngles = new Vector3 (0,0 , 0);
	
	}
}
}
