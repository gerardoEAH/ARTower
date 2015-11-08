using UnityEngine;
using System.Collections;
//using UnityEngine.UI;

public class CreateTowerUIControl : MonoBehaviour {

	private int towerType; //0->Nada, 1->Basic, 2->Air, 3->Power
	private bool spawning;
	private bool selectedTower;
	private bool spawned;
	private GameObject tower;

	public Transform spawnArea;
	public GameObject[] towersPrefab;

	public void TowerBasic(){
		if (!spawned) {
			towerType = 1;
			spawning = true;

			if (selectedTower) {
				Destroy (tower);
			}

			selectedTower = true;
		}
	}

	public void TowerAir(){
		if (!spawned) {
			towerType = 2;
			spawning = true;

			if (selectedTower) {
				Destroy (tower);
			}

			selectedTower = true;
		}
	}

	public void TowerPower(){
		if (!spawned) {
			towerType = 3;
			spawning = true;

			if (selectedTower) {
				Destroy (tower);
			}

			selectedTower = true;
		}
	}

	public void TowerX(){
		spawning = false;
		
		if (selectedTower) {
			Destroy(tower);
			selectedTower = false;
		} 
		spawned = false;
	}

	public void TowerO(){
		towerType = 0;
		spawning = false;

		if (selectedTower && spawned) {
			//Pierdes dinero
			Destroy(tower.GetComponent<MoveTower>()); //Destruye el script para moverlo porque ya se instancio
			spawned = false;
			tower = null;
		}
	}

	void SpawnTower(int type){

		switch (type) {
		case 0: 
			break;
			
		case 1: //Tower Basic
			tower = (GameObject) Instantiate(towersPrefab[0], spawnArea.position, spawnArea.rotation) as GameObject;
			spawned = true;
			break;
			
		case 2: //Tower Air
			tower = (GameObject) Instantiate(towersPrefab[1], spawnArea.position, spawnArea.rotation) as GameObject;
			spawned = true;
			break;
			
		case 3: //Tower Power
			tower = (GameObject) Instantiate(towersPrefab[2], spawnArea.position, spawnArea.rotation) as GameObject;
			spawned = true;
			break;
			
		default:
			Debug.Log("Ninguna Torre Seleccionada");
			break;
			
		}

		if (tower) {
			tower.AddComponent<MoveTower>(); //Le da el script para moverlo porque esta en seleccionado

		}


	}

	void Start(){
		towerType = 0; //Ningun Tipo
	}

	void Update(){
		
		if (spawning && !spawned) {
			SpawnTower(towerType);
		}


	}

}
