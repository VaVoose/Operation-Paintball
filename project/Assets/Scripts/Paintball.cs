using UnityEngine;
using System.Collections;

public class Paintball : MonoBehaviour {

	public float bounceChance = .7f;
	public float timeLeft = 5f;

	void Update(){
		timeLeft = timeLeft - Time.deltaTime;
		if (timeLeft < 0) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision col){
		float bounce = Random.value;
		if (bounce < bounceChance) {
			Destroy (this.gameObject);
		}

	}
}
