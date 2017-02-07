using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour{

    public int zoom;
    public int normal;
    public float smoth;
    public bool isZoomed;
    public float TimerInicial;
    public float TimerFinal = 1f;
    public bool entrouZoom = false;

    public Transform target;
    private GameObject Player;
    PlayerInputController Playerinput;
    private GameObject CameraMain;
    CameraFollow MycameraFollow;

   // public float FollowTime;
   // public Vector3 offset;
   // public float offsetx;
  //  public float offsety;
  //  public float spd;

    void Start(){
        Camera.main.orthographic = true;
        isZoomed = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        CameraMain = GameObject.FindGameObjectWithTag("MainCamera");
        Playerinput = Player.GetComponent<PlayerInputController>();
        MycameraFollow = CameraMain.GetComponent<CameraFollow>();
    }

    void Update(){

        if (Playerinput.LandingState == false){
            MycameraFollow.enabled = true;
        }
        
		if (Playerinput.LandingState == true){
            if (!entrouZoom){
                 TimerInicial = 0;
                entrouZoom = true;
            }
            // GetComponent<Camera>().orthographicSize= 10;
            //  iTween.MoveUpdate(this.gameObject, iTween.Hash("position", target.position + offset, "time", FollowTime, "easytype", iTween.EaseType.easeInOutSine));
            //   offset = new Vector3(offsetx, offsety, -10);

            GetComponent<Camera>().orthographicSize = Mathf.Lerp(GetComponent<Camera>().orthographicSize, zoom, (TimerInicial += Time.deltaTime * smoth) / TimerFinal);

            //  float up = Input.GetAxis("Vertical") * spd;
            //  float side = Input.GetAxis("Horizontal") * spd;

            // offsetx += Time.deltaTime * side;
            // offsety += Time.deltaTime * up;

        }
    
        else
        {
			if (entrouZoom){
				TimerInicial = 0;
				entrouZoom = false;
			}
               
                
    

            GetComponent<Camera>().orthographicSize = Mathf.Lerp(GetComponent<Camera>().orthographicSize, normal, (TimerInicial += Time.deltaTime * smoth) / TimerFinal);
           
                //   Playerinput.LandingState = false;
            


            
           // GetComponent<Camera>().orthographicSize = 1;
         
            //  GetComponent<Camera>().orthographicSize = Mathf.Lerp(GetComponent<Camera>().orthographicSize, normal, (TimerInicial += Time.deltaTime * smoth) / TimerFinal);
        }
            
       

   
               

        

    }
}
