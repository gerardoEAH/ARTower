using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class CreateTower : MonoBehaviour, IPointerDownHandler, IDragHandler, IEndDragHandler , IPointerUpHandler {
	

	public float smoothing;
	
	private Vector2 origin;
	private Vector2 direction;
	private Vector2 smoothDirection;

	private bool touched;
	private int pointerID;

	void Awake () {
		direction = Vector2.zero;
		touched = false;
	}


	public void OnPointerDown (PointerEventData data) {
		if (!touched) {
			touched = true;
			pointerID = data.pointerId;
			origin = data.position;

		}
	}
	
	public void OnDrag (PointerEventData data) {
		if (data.pointerId == pointerID) {
			Debug.Log("Ondrag");
			Vector2 currentPosition = data.position;
			Vector2 directionRaw = currentPosition - origin;

			direction = directionRaw.normalized;

		}
	}

	public void OnEndDrag(PointerEventData data){
		if (data.pointerId == pointerID) {
			Debug.Log("ended");

			direction = Vector3.zero;
			touched = false;
		}
	}
	
	public void OnPointerUp (PointerEventData data) {
		if (data.pointerId == pointerID) {
			direction = Vector3.zero;
			touched = false;
		}
	}
	
	public Vector2 GetDirection () {
		smoothDirection = Vector2.MoveTowards (smoothDirection, direction * 4, smoothing);

		return smoothDirection;
	}








	// Update is called once per frame
	void Update () {

		/*
		float x, y;
		Vector3 position;
		Camera camera = GetComponentInChildren <Camera> ();

		if (Input.touchCount > 0) {
			x = Input.GetTouch(0).position.x;
			y = Input.GetTouch(0).position.y;

			position = camera.ScreenToWorldPoint(new Vector3(x,y, camera.nearClipPlane));

			Debug.DrawRay(position, this.transform.forward * 1000, Color.green);
			Ray ray = new Ray(position, this.transform.forward * 1000);
			
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, 1000)){
				if(hit.collider.tag == "FreeSpace"){
					Destroy(hit.collider.gameObject);
				}
			}
		}
*/
		/*
		if (Input.touchCount > 0) {
			Debug.DrawRay(this.transform.position, this.transform.forward * 1000, Color.green);
			Ray ray = new Ray(this.transform.position, this.transform.forward * 1000);

			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, 1000)){
				if(hit.collider.tag == "FreeSpace"){
					Destroy(hit.collider.gameObject);
				}
			}
		} */
	
	}
}
