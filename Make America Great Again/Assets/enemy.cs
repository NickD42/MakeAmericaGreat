using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
    Vector3 enemyPos = new Vector3(0, 0, 0);
    float timer = 0f;
    char dir;
    float speed = 0f;
    public Sprite protester;
	// Use this for initialization
	void Start () {
        enemyPos = transform.position;
        protester = GetComponent<SpriteRenderer>().sprite;
	}

    //bool facingLeft(bool facingdirection)
    //{
    //    if (facingdirection)
    //    {
    //        return true;
    //    }
    //    else return false;
            
    //}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            timer = 0f;
            int randDirChange = Random.Range(1, 4);
            switch (randDirChange)
            {
                case 1:
                    dir = 'l';
                    break;
                case 2:
                    dir = 'u';
                    break;
                case 3:
                    dir = 'r';
                    break;
                case 4:
                    dir = 'd';
                    break;

            }

        }
        switch (dir)
        {
            case 'l':
                {
                    speed = 3;
                    enemyPos.x -= speed * Time.deltaTime;
                    transform.position = enemyPos;
                    if (enemyPos.x < -9)
                    {
                        dir = 'd';
                    }
                }
                break;
            case 'r':
                {
                    speed = 3;
                    enemyPos.x += speed * Time.deltaTime;
                    transform.position = enemyPos;
                    if (enemyPos.x > 9)
                    {
                        dir = 'u';
                    }
                }
                break;
            case 'd':
                {
                    speed = 5;
                    enemyPos.y -= speed * Time.deltaTime;
                    transform.position = enemyPos;
                    if (enemyPos.y < -5)
                    {
                        transform.localRotation = Quaternion.Euler(0, 180, 0);
                        dir = 'r';
                    }
                }
                break;
            case 'u':
                {
                    speed = 5;
                    enemyPos.y += speed * Time.deltaTime;
                    transform.position = enemyPos;
                    if (enemyPos.y > 3)
                    {
                        transform.localRotation = Quaternion.Euler(0, 0, 0);
                        dir = 'l';
                    }
                }
                break;


        }
    }
}
