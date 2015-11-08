using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	Text text;
	public static float tiempo=0.0f;
	// Use this for initialization
	void Start () {

		text = GetComponent<Text> (); 
	
	}
	
	// Update is called once per frame
	void Update () {
		tiempo = tiempo  + Time.deltaTime;




		text.text="Tiempo: "+tiempo.ToString("f0");
	
	}
}
