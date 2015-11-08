using UnityEngine;
using System.Collections;

public class ControladorScript : MonoBehaviour {

	public static bool enemigo0;

	// Use this for initialization
	void Start () {
		enemigo0 =false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Enemy")
		enemigo0 =true;
		Debug.Log (other.name);
		
		
	}
	void OnTriggerExit(Collider other)
	{
		enemigo0 = false;
		Debug.Log ("Estas afuera");
	}
}
