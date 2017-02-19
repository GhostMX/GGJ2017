using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {
    public GameObject SpawnPostion;
    public GameObject ObjetcToSpawn;
    private float timertospawn;
    public float TimerSpawn;
    public float delay;
    private bool firstTime;
	// Use this for initialization
	void Start () {
        timertospawn = delay;
	}
	
	// Update is called once per frame
	void Update () {
        timertospawn -= Time.deltaTime;

        if (timertospawn <= 0) {
            GameObject Espinho = (GameObject)Instantiate(ObjetcToSpawn);
            Espinho.transform.position = SpawnPostion.transform.position;
            timertospawn = TimerSpawn;
        }        
    }   
}
