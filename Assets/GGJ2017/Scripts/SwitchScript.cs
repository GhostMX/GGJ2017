using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour {

    public GameObject weightObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.Equals(weightObject))
        {
            this.doSomething();
        }
    }

    private void doSomething()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
