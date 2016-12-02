using UnityEngine;
using System.Collections;

public class Marker : MonoBehaviour {

	public GameObject paintballPrefab;

	public float speed(){
		CharacterController controller = GameObject.Find("FPSController").GetComponent<CharacterController> ();
		Vector3 playerVelocity = new Vector3 (controller.velocity.x, controller.velocity.y, controller.velocity.z);
		float speed = controller.velocity.magnitude;

		return speed;
	}

	void Update(){
		GameObject goPaintball;
		/*CharacterController controller = gameObject. ();
		Vector3 playerVelocity = new Vector3 (controller.velocity.x, controller.velocity.y, controller.velocity.z);
		float playerSpeed = controller.velocity.magnitude; 
		*/
		float curSpeed = speed ();
		print (curSpeed);


		if (Input.GetMouseButtonDown (0)) {
			goPaintball = Instantiate (paintballPrefab);
			goPaintball.GetComponent<MeshRenderer> ().material.color = Random.ColorHSV();
			goPaintball.transform.position = this.gameObject.transform.position;
			goPaintball.transform.rotation = this.gameObject.transform.rotation; 
			goPaintball.GetComponent<Rigidbody> ().AddRelativeForce (new Vector3 (0, 0, 5000));
		}
	}

}
