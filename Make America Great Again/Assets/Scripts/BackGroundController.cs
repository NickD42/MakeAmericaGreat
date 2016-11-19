using UnityEngine;
using System.Collections;


public class BackGroundController : MonoBehaviour {

   public GameManager gameManager;
    GameObject t_gameManager;
    GameObject t_gameManager2;
    public Sprite level0;
    public Sprite level1;
    public Sprite level2;
    public Sprite level3;
    public Sprite level4;
    
    // Use this for initialization
    void Start ()
    {
        gameManager = GameManager.FindObjectOfType<GameManager>();
        //  t_gameManager = GameObject.FindWithTag("GameManager");
        //gameManager = t_gameManager.GetComponent<GameManager>();

        GetComponent<SpriteRenderer>().sprite = level0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //short level = gameManager.LevelsCompleted;
        switch (gameManager.LevelsCompleted)
        {
            case 0:
                Debug.Log("level0");
                this.GetComponent<SpriteRenderer>().sprite = level0;
                break;
            case 1:
                Debug.Log("level1");
                this.GetComponent<SpriteRenderer>().sprite = level1;
                break;
            case 2:
                this.GetComponent<SpriteRenderer>().sprite = level2;
                break;
            case 3:
                this.GetComponent<SpriteRenderer>().sprite = level3;
                break;
            case 4:
                this.GetComponent<SpriteRenderer>().sprite = level4;
                break;
        }
    }
}