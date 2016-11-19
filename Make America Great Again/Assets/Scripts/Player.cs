using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    Vector3 Pposition;
    public float speed = 0.05f;
    public Sprite charSprite;
    public Sprite Hilory;
    public Sprite TheDonald;
   
	// Use this for initialization
	void Start() {
        DontDestroyOnLoad(this);
        Pposition = transform.position;
        charSprite = GetComponent<SpriteRenderer>().sprite;
	}
    Sprite SwitchSprite()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if(charSprite==Hilory)
            {
                charSprite = TheDonald;
            }else if (charSprite==TheDonald)
            {
                charSprite = Hilory;
            }
        }
        GetComponent<SpriteRenderer>().sprite = charSprite;
        return charSprite;
    }
   void move()
    {
        if (Input.GetAxisRaw("Vertical") > 0.5)
        {
            Pposition.y += speed;
            //Debug.Log("up");
        }
        if (Input.GetAxisRaw("Horizontal") < -0.5)
        {
            Pposition.x -= speed;
            //Debug.Log("left");
        }
        if (Input.GetAxisRaw("Vertical") < -0.5)
        {
            Pposition.y -= speed;
            //Debug.Log("down");
        }
        if (Input.GetAxisRaw("Horizontal") > 0.5)
        {
            Pposition.x += speed;
            //Debug.Log("right");
        }
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
        //Debug.Log(Input.GetAxisRaw("Vertical"));
        transform.position = Pposition;
    }
	// Update is called once per frame
	void Update () {
        move();
        //SwitchSprite();
	}
    
}
