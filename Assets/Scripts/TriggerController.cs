using UnityEngine;
using System.Collections;

public class TriggerController : MonoBehaviour {



	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Enemy")
		{
			transform.LookAt(other.transform.position);

			Debug.Log("Estas viendo un enemigo Terrestre");
		}
		

	}

}
