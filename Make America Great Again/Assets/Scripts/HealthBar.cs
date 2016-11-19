using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

    public Sprite full;
    public Sprite twoThirds;
    public Sprite oneThird;
    public Sprite empty;

    GameObject random;
    GameManager manager;
    SpriteRenderer renderer;
    // Use this for initialization
	void Start () {
        random = GameObject.FindGameObjectWithTag("GameManager");
        manager = random.GetComponent<GameManager>();
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        switch (manager.HP)
        {
            case 3:
                renderer.sprite = full;
                break;
            case 2:
                renderer.sprite = twoThirds;
                break;
            case 1:
                renderer.sprite = oneThird;
                break;
            case 0:
                renderer.sprite = empty;
                break;
        }
	}
}
