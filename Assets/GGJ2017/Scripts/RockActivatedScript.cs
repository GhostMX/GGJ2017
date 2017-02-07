using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockActivatedScript : MonoBehaviour {

    public GameObject prefabSonar;
    private bool isActivated = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void throwRock(Vector3 sonar)
    {
        Rigidbody2D body = this.GetComponent<Rigidbody2D>();
        body.constraints = RigidbodyConstraints2D.None;
        body.AddForce(new Vector2(20f, 0));
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.GetType());
        this.throwRock(collision.gameObject.transform.position);
    }


}
