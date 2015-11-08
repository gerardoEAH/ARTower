using UnityEngine;
using System.Collections;

public class MoveTower : MonoBehaviour {

	private CreateTower createTower;

	// Use this for initialization
	void Start () {
		createTower = GameObject.Find ("ImageTouch&Move").GetComponent<CreateTower> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void FixedUpdate () {


		Vector2 direction = createTower.GetDirection ();
		this.transform.Translate (new Vector3(direction.x, 0, direction.y) * Time.deltaTime);
	}

}
