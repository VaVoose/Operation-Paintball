using UnityEngine;
using System.Collections;

public class Marker : MonoBehaviour {

	public GameObject paintballPrefab;

	void Update(){
		GameObject goPaintball;
		/*CharacterController controller = gameObject. ();
		Vector3 playerVelocity = new Vector3 (controller.velocity.x, controller.velocity.y, controller.velocity.z);
		float playerSpeed = controller.velocity.magnitude; 
		*/



		if (Input.GetMouseButtonDown (0)) {
			goPaintball = Instantiate (paintballPrefab);
			goPaintball.GetComponent<MeshRenderer> ().material.color = Random.ColorHSV();
			goPaintball.transform.position = this.gameObject.transform.position;
			goPaintball.transform.rotation = this.gameObject.transform.rotation;
			goPaintball.GetComponent<Rigidbody> ().AddRelativeForce (new Vector3 (0, 0, 5000));
		}
	}

}
