using UnityEngine;
using System.Collections;

public class Marker : MonoBehaviour {

	public GameObject paintballPrefab;

	public float speed(){

		//float curSpread = GameObject.Find("FirstPersonCharacter").GetComponent

		CharacterController controller = GameObject.Find("FPSController").GetComponent<CharacterController> ();
		Vector3 playerVelocity = new Vector3 (controller.velocity.x, controller.velocity.y, controller.velocity.z);
		float speed = controller.velocity.magnitude;

		return speed;
	}

	void Update(){
		GameObject goPaintball;
		float curSpeed = speed ();

		float randVForce = Random.Range(-100f, 100f);
		float randHForce = Random.Range(-100f, 100f);
		float vForce = randVForce * curSpeed;
		float hForce = randHForce * curSpeed;



		if (Input.GetMouseButtonDown (0)) {
			goPaintball = Instantiate (paintballPrefab);
			goPaintball.GetComponent<MeshRenderer> ().material.color = Random.ColorHSV();
			goPaintball.transform.position = this.gameObject.transform.position;
			goPaintball.transform.rotation = this.gameObject.transform.rotation; 
			goPaintball.GetComponent<Rigidbody> ().AddRelativeForce (new Vector3 (hForce, vForce, 5000));
		}
	}

}
