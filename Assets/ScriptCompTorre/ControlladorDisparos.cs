using UnityEngine;
using System.Collections;

public class ControlladorDisparos : MonoBehaviour {

	public GameObject bala, spawnX;

	float timeactual;


	// Use this for initialization
	void Start () {
		timeactual = 0;

	
	}

	
	// Update is called once per frame
	void Update () {




		if (ControladorScript.enemigo0 && Time.time > timeactual) {

			Instantiate(bala,spawnX.transform.position, spawnX.transform.rotation);
			//timeactual=Time.time+.5;
			timeactual= Time.time+1;
		}


	
	}
}
