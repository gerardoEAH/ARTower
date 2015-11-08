using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

public Transform []Posiciones;
NavMeshAgent nav;
int cont;
float random;
public float EnemyLife;
public float EnemyDamage;
public int RewardCoins;

void Start(){
	RewardCoins = 5;
	nav = GetComponent<NavMeshAgent>();
	cont = 0;
	random = Random.Range(1,4);
	Posiciones[0] = GameObject.FindWithTag("Pos0").transform;
	Posiciones[1] = GameObject.FindWithTag("Pos1").transform;
	Posiciones[2] = GameObject.FindWithTag("Pos2").transform;
	Posiciones[3] = GameObject.FindWithTag("Pos3").transform;
	Posiciones[4] = GameObject.FindWithTag("Pos4").transform;
	Posiciones[5] = GameObject.FindWithTag("Pos5").transform;
	Posiciones[6] = GameObject.FindWithTag("Pos6").transform;

}

void Update(){


	if (cont == 0)
	{
		if (random == 1 )
		 nav.SetDestination(Posiciones[1].position);
		else if (random == 2 )
		 nav.SetDestination(Posiciones[2].position);
		else if (random == 3 )
		 nav.SetDestination(Posiciones[3].position);
		else if (random == 4 )
		 nav.SetDestination(Posiciones[4].position);

		cont++;
	}

	if (transform.position.x == Posiciones[1].position.x)
	 nav.SetDestination(Posiciones[6].position);

	 else if ((transform.position.x == Posiciones[2].position.x) || (transform.position.x == Posiciones[3].position.x) || (transform.position.x == Posiciones[4].position.x))
	  nav.SetDestination(Posiciones[5].position);

	 if (transform.position.x == Posiciones[5].position.x)
	 nav.SetDestination(Posiciones[6].position);
}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "My Fire")
		{
			EnemyLife -= 10f;
			if(EnemyLife <= 0)
			{
				// se muere;
				VidaCastillo.CoinsNum += RewardCoins;
				Destroy(gameObject);
			}
		}
	}

	void DestroySelf()
	{
		Destroy(gameObject);
	}
}
