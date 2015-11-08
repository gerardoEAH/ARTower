using UnityEngine;
using System.Collections;

public class EventosMarcador : MonoBehaviour {

	public Canvas notificacion;

	private bool detener;

	
	// Update is called once per frame
	void Update () {
		if (detener && Time.frameCount >= 2) {
			Time.timeScale = 0f;
		}
		
		if(Input.GetKeyDown(KeyCode.Q)){
			MarcadorPerdido();
		}else if (Input.GetKeyDown(KeyCode.W)){
			MarcadorEncontrado();
		}

	}


	
	
	public void MarcadorEncontrado()
	{
		Debug.Log ("ENCONTRADO");
		if (notificacion != null) {
			notificacion.enabled=false;
		}
		//ResumeGame
		Time.timeScale = 1f;
		detener = false;
	}
	
	
	public void MarcadorPerdido()
	{
		Debug.Log ("PERDIDO");
		if (notificacion != null) {
			notificacion.enabled=true;
		}
		//PauseGame
		detener = true;
		
	}


}
