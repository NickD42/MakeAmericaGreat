using UnityEngine;
using System.Collections;


public class BackGroundController : MonoBehaviour {

    GameObject gameManager = new GameObject();

    public Sprite Level0;
    public Sprite level1;
    public Sprite level2;
    public Sprite level3;
    public Sprite level4;
    
    // Use this for initialization
    void Start () {

        gameManager = GameObject.Find("GameManager");

        //switch(gameManager.LevelsCompleted)
        //{
       //      case 
      //  }
        GetComponent<SpriteRenderer>().sprite = level1;
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
