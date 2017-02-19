using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeImage : MonoBehaviour {
	public float Color1;
	public float Color2;
	public float Color3;
	public float duracao;
	private Image img;
	public float tempototal;
	private float contador;

	// Use this for initialization
	void Start () {
		img =  GameObject.Find("Background").GetComponent<Image>();
	}

	// Update is called once per frame
	void Update () {

		if (duracao <= 1.5) {
			duracao += 1.5f / tempototal * Time.deltaTime;
			contador = duracao;
		}

		if (duracao > 1.5f) {
			duracao += 1.5f / tempototal * Time.deltaTime;
			contador -= 1.5f / tempototal * Time.deltaTime;
		}
		img.color = new Color (Color1, Color2, Color3,contador);
	}
}