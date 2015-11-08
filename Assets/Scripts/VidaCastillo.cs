using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class VidaCastillo : MonoBehaviour {

	public GameObject LifeBar;
	private Slider slide;
	[SerializeField] public Text CoinsText;
	public static int CoinsNum;
	// Use this for initialization
	void Start () {
		slide = LifeBar.GetComponent<Slider>();
		LifeBar = null;
		CoinsNum = 0;
	}

	void Update()
	{
		CoinsText.text = "Coins: " + CoinsNum.ToString();
	}

	void OnCollisionEnter(Collision Other)
	{
		//Debug.Log("Detecte la Collision");
		if ((Other.gameObject.tag == "Enemy" || Other.gameObject.tag == "Air")  && slide.value > 0) 
		{
			//Debug.Log("Quiero Quitar vida");
			slide.value -= Other.gameObject.GetComponent<EnemyScript>().EnemyDamage;
			Destroy(Other.gameObject);
		}
		else if (slide.value <= 0)
		{
			// aqui va lo que pierde.
		}
	}
}
