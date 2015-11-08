using UnityEngine;
using System.Collections;

public class ControlladorMonstruo : MonoBehaviour {

	public float speed=5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) {
			transform.Translate(Vector3.right*Time.deltaTime * speed, Space.Self);

		}if (Input.GetKey (KeyCode.B)) {
			transform.Translate(Vector3.left*Time.deltaTime *speed, Space.Self);
			
		}

	
	}
}
