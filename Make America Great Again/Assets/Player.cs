using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    Vector3 Pposition;
    public float speed = 0.05f;
	// Use this for initialization
	void Start() {
        Pposition = transform.position;

	}
   void move()
    {
       if(Input.GetKey(KeyCode.W))
        {
            Pposition.y += speed;
            Debug.Log("up");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Pposition.x -= speed;
            Debug.Log("left");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Pposition.y -= speed;
            Debug.Log("down");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Pposition.x += speed;
            Debug.Log("right");
        }
        transform.position = Pposition;
    }
	// Update is called once per frame
	void Update () {
        move();
	}
    
}
