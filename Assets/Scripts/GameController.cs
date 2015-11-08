using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject []hazard;
	public Transform spawnStuff;
	public Transform spawnRobotShip;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public GameObject buyTowersCanvas;
	public GameObject shipUi;

	/*
	public GUIText scoreText; 
	public GUIText restartText;
	public GUIText gameOverText;

	private bool gameOver;
	private bool restart;
	private int score;
	*/ 

	private int waveCount;
	private float ranInst;

	void Start()
	{
		buyTowersCanvas.SetActive(false);
		waveCount = 0;
		//gameOver = false;
		//restart = false;
		//restartText.text = "";
		//gameOverText.text = "";
		StartCoroutine (SpawnWaves ());
		//score = 0;
		//scoreText.text = "Score: 0";
	}

	void Update ()
	{
		/*
		if (restart) 
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}*/
	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while (true) 
		{
			if (waveCount < 5)
			{
				buyTowersCanvas.SetActive(false);
				shipUi.SetActive(true);
				for (int i=0; i < hazardCount; i++) 
				{
					ranInst = Random.Range(0,3);
			
					Quaternion spawnRotation = Quaternion.identity;
					if (ranInst < 1)
						Instantiate (hazard[3], spawnStuff.position, spawnRotation);
					else if (ranInst < 2)
						Instantiate (hazard[4], spawnStuff.position, spawnRotation);
					else if (ranInst < 3)
						Instantiate (hazard[2], spawnStuff.position, spawnRotation);

					yield return new WaitForSeconds (spawnWait); 


				}

				//sdgsdaghshdfhdfh
				buyTowersCanvas.SetActive(true);
				shipUi.SetActive(false);

				waveCount++;
			}

			else if (waveCount >= 5)
			{
				for (int i=0; i < hazardCount; i++) 
				{
					ranInst = Random.Range(0,2);
	
					Quaternion spawnRotation = Quaternion.identity;
					if (ranInst < 1)
						Instantiate (hazard[3], spawnRobotShip.position, spawnRotation);
					else if (ranInst < 2)
						Instantiate (hazard[4], spawnRobotShip.position, spawnRotation);
					

					yield return new WaitForSeconds (spawnWait); 
				}

				waveCount++;
			}

			yield return new WaitForSeconds (waveWait);

			hazardCount += 2;

			/*

			if (gameOver)
			{
				restartText.text = "Press 'R' for restart";
				restart = true;
				break;
			}
			*/
		 };

	}
/*
	public void UpdateText (int scoreValue)
	{
		score += scoreValue;
		scoreText.text = "Score: " + score.ToString();
	}

	public void GameOver ()
	{
		gameOverText.text = "Game Over!";
		gameOver = true;
	}
	*/
}
