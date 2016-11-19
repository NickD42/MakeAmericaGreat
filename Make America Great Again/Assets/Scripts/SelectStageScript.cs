using UnityEngine;
using System.Collections;

public class SelectStageScript : MonoBehaviour {

    Ray ray;
    RaycastHit hit;

    Color tmp;

    // Use this for initialization
    void Start ()
    {
        tmp = this.GetComponent<SpriteRenderer>().color;
        tmp.a = 0f;
        this.GetComponent<SpriteRenderer>().color = tmp;
    }
	
	// Update is called once per frame
	void Update ()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Color tmp = this.GetComponent<SpriteRenderer>().color;
            tmp.a = 100f;
            this.GetComponent<SpriteRenderer>().color = tmp;
        }
        else
        {

        }
    }
}
