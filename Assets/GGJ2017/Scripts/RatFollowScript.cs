using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatFollowScript : MonoBehaviour {

    // Use this for initialization
    public GameObject ratFollower;
    public GameObject following;
    private bool isFollowing = false;
	private GameObject Player;
    AudioSource Audio;
	public AudioClip ThisAudio;
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
		Audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {




        if (this.isFollowing){
            float ratX = ratFollower.transform.position.x;
            float playerX = following.transform.position.x;


			if (Player.transform.localScale.x >0){
				ratFollower.transform.localScale = new Vector3 (1, 1, 1);


			}
			if (Player.transform.localScale.x <0) {
				ratFollower.transform.localScale = new Vector3 (-1, 1, 1);

			}



		
            if (ratX != playerX){
                float velX = (playerX - ratX)*3;
                ratFollower.GetComponent<Rigidbody2D>().velocity = new Vector2(velX, ratFollower.GetComponent<Rigidbody2D>().velocity.y);
            }
        }
	}

	public void OnTriggerEnter2D (Collider2D other){

		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "Player"){
            this.isFollowing = true;
        }
		if (other.gameObject.tag =="Spike"){
	//		Audio.PlayOneShot (ThisAudio);
		//	Destroy (gameObject);

		}
    }

    public void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.tag == "Player"){
            this.isFollowing = false;
        }
    }



}
