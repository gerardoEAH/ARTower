using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody rb = this.GetComponent<Rigidbody>();
		rb.AddForce (transform.forward * 15000);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.name == "Enemy") {

			//EliminarDisparo();
			if(other.gameObject.GetComponent<EnemyScript>().EnemyLife > 0)
			{
				other.gameObject.GetComponent<EnemyScript>().EnemyLife -= 10;
				Destroy(gameObject);
			}

			else
			{
				//Instantiate(Explosion,other.gameObject.transform.position,Quaternion.identity);
				Destroy(gameObject);
			}
		}



	}

	void EliminarDisparo()
	{
		Destroy (gameObject);
		GetComponentInChildren<ParticleSystem>().enableEmission = false;
	}
}
