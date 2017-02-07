using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerInputController : MonoBehaviour {

 
	Rigidbody2D rgd;
	public float spd;
	public bool LandingState;
	public string LandingTag;
	public float LandingTime;
	public float HowManyisLandingTime;
	Animator MyAnimator;
	public bool LeverOn;
	public float DoorTimer;
	public float DoorTimer2;
	Animator anim;
	public bool Damage = false;
	public float Scalex;
	public float Scaley;
	public float Scalez;
	public float spd2;
	LevelManager MyLevelmanager;
    AudioSource MyAudio;
    private GameObject sonar;


	// Use this for initialization
	void Start () {
        MyAudio = GetComponent<AudioSource>();
		rgd = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator>();
		MyLevelmanager = FindObjectOfType<LevelManager> ();
        sonar = this.gameObject.transform.FindChild("Sonar").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (Damage == true)
        {

            MyAudio.Play();
        }

        anim.SetBool("Landing", LandingState);
		anim.SetBool("Damage", Damage);

		Damage = false;

       

		// Se está voando :
		if (LandingState == false) {


			float up = Input.GetAxis ("Vertical") * spd;
			float side = Input.GetAxis ("Horizontal") * spd;
			transform.Translate (side, up, 0);


            if (Input.GetAxis("Horizontal")>0 ){
			transform.localScale = new Vector3(Scalex , Scaley, Scalez);
	//			transform.eulerAngles = new Vector3 (0,0,0);
			}
            if (Input.GetAxis("Horizontal") < 0)
            { 
			transform.localScale = new Vector3(-Scalex , Scaley, Scalez);
			//	transform.eulerAngles = new Vector3 (0,180,0);

            }


        }
		// Se está no ponto de observação .
		if (LandingState == true) {
			//LandingTime -= Time.deltaTime;
						spd =0;

            if (Input.GetAxis("Vertical") < 0 && LandingState == true)
            {
                LandingState = false;
                sonar.gameObject.SetActive(false);
            }

        }


		if (LandingState==false) {

		//	LandingState = false;
		spd = spd2; 
		}


       
		if (LeverOn == true) {
			DoorTimer -= Time.deltaTime;
		}
		if (DoorTimer < 0) {
			LeverOn = false;
			DoorTimer = DoorTimer2;
		}
		if (Input.GetKeyDown(KeyCode.Escape)){
			Debug.Log("Go to Game");
			MenuGame();
		}

    }
    void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == LandingTag && LandingState == false) {
			LandingState = true;
            sonar.gameObject.SetActive(true);
		}
		if (col.gameObject.tag == "Spike") {
			this.gameObject.transform.position = MyLevelmanager.currentCheckPoint;
			Damage = true;
		}
		if (col.gameObject.tag == ("Lever") && LandingState == false) {
			LeverOn = true;

		}
	}
	public void MenuGame(){
		SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
	}
}
