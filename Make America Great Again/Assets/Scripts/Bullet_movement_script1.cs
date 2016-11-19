using UnityEngine;
using System.Collections;

public class Bullet_movement_script1 : MonoBehaviour {

	float maxSpeed1=5f;
	
	// Update is called once per frame
	void Update () {
	
		Vector3 Pos = transform.position;
		Vector3 velocity = new Vector3 ( maxSpeed1 * Time.deltaTime, 0, 0);
		Pos -=velocity;
		transform.position = Pos;
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
		if (transform.position.x > max.x) {
			Destroy (gameObject);
		
			//Debug.Log ("BulletMove Died");
		}
	}
}
