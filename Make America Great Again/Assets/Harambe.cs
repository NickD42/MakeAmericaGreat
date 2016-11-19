using UnityEngine;
using System.Collections;

public class Harambe : MonoBehaviour {
    Vector2 BossPos;

    char dir;
    //public GameObject sharkRight;
    //public GameObject sharkLeft;
    //public float fireRate;
    //float nextFire;
    //public GameObject upper, lower;
    //public Transform otherBulletSpawn;
    //int health, lowerHealth, upperHealth;
    //float BossFire = 0;
    //public Sprite almostDead;
    private float speed;
    // Use this for initialization
    private float timer;
    void Start()
    {
        BossPos = transform.position;
        speed = 2f;
        dir = 'l';
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
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
                    BossPos.x -= speed * Time.deltaTime;
                    transform.position = BossPos;
                    if (BossPos.x < -9)
                    {
                        dir = 'd';
                    }
                }
                break;
            case 'r':
                {
                    speed = 3;
                    BossPos.x += speed * Time.deltaTime;
                    transform.position = BossPos;
                    if (BossPos.x > 9)
                    {
                        dir = 'u';
                    }
                }
                break;
            case 'd':
                {
                    speed = 5;
                    BossPos.y -= speed * Time.deltaTime;
                    transform.position = BossPos;
                    if (BossPos.y < -5)
                    {
                        dir = 'r';
                    }
                }
                break;
            case 'u':
                {
                    speed = 5;
                    BossPos.y += speed * Time.deltaTime;
                    transform.position = BossPos;
                    if (BossPos.y > 3)
                    {
                        dir = 'l';
                    }
                }
                break;


        }

        //Health();
    }

    //void shootRight()
    //{
    //    nextFire = fireRate;
    //    Vector3 Offset = new Vector3(2, 0, 0);
    //    //GameObject newbullet = (GameObject)Instantiate (bullet);
    //    //newbullet.transform.position = BulletSpawn.transform.position; 
    //    GameObject newbullet = (GameObject)Instantiate(sharkRight, transform.position + Offset, transform.rotation);

    //}
    //void shootLeft()
    //{
    //    Vector3 Offset = new Vector3(2, 0, 0);
    //    //GameObject newbullet = (GameObject)Instantiate (bullet);
    //    //newbullet.transform.position = BulletSpawn.transform.position; 
    //    GameObject newbullet = (GameObject)Instantiate(sharkLeft, transform.position + Offset, transform.rotation);
    //}
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.tag == "Player")
        {
            Destroy(gameObject);
        }
        //Detect collision between object A and object B

    }
    void Health()
    {
        //&& upper.GetComponent<NeptuneColLowerBoss>().health<0
        //if (lower.GetComponent<NeptuneColLowerBoss>().dead && upper.GetComponent<NeptuneColLowerBoss>().dead)
        //{
        //    Debug.Log("hello");
        //    GetComponent<SpriteRenderer>().sprite = almostDead;
        //}

    }
}
