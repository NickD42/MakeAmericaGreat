using UnityEngine;
using System.Collections;

public class LifeScript : MonoBehaviour {

    GameObject random;
    GameManager manager;
    SpriteRenderer renderer;
    // Use this for initialization
    void Start ()
    {
        random = GameObject.FindGameObjectWithTag("GameManager");
        manager = random.GetComponent<GameManager>();
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	    switch(gameObject.name)
        {
            case "IVoted1":
                renderer.enabled = manager.lives >= 1;
                break;
            case "IVoted2":
                renderer.enabled = manager.lives >= 2;
                break;
            case "IVoted3":
                renderer.enabled = manager.lives >= 3;
                break;
        }
	}
}
