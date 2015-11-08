using UnityEngine;
using System.Collections;

public class TriggerAereo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Air")
		{
			transform.LookAt(other.transform.position);

			Debug.Log("Estas viendo un enemigo aereo");
		}
		

	}
}
