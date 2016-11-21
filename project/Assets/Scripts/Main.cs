using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	public GameObject paintballPrefab;

	void Update(){
		GameObject goPaintball;


		if (Input.GetMouseButtonDown (0)) {
			goPaintball = Instantiate (paintballPrefab);
			goPaintball.GetComponent<MeshRenderer> ().material.color = Random.ColorHSV();
			goPaintball.transform.position = this.gameObject.transform.position;
			goPaintball.transform.rotation = this.gameObject.transform.rotation;
			goPaintball.GetComponent<Rigidbody> ().AddRelativeForce (new Vector3 (0, 0, 5000));
		}
	}
		
}
