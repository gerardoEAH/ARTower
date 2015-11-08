
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Disparar : MonoBehaviour {

	public Transform disparoPrefab;

	public float tiempoEntreDisparos = 1f;
	private float siguienteDisparo = 0f;
	public float limiteDisparo;
	public float contadorDisparos;


	// Use this for initialization
	void Start () {

	
	}

	// Update is called once per frame
	void Update	(){

		if (Input.touchCount > 0 && Time.time > siguienteDisparo )
		{
			siguienteDisparo = Time.time + tiempoEntreDisparos;
			Instantiate(disparoPrefab, transform.position, transform.rotation);
		}
	}


}