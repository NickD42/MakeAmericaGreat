using UnityEngine;
using System.Collections;

public class StageSelectMidWestScript : MonoBehaviour {

    Color colorOn;
    Color colorOff;

    void OnMouseEnter()
    {
        this.GetComponent<SpriteRenderer>().color = colorOn;
    }

    void OnMouseExit()
    {
        this.GetComponent<SpriteRenderer>().color = colorOff;
    }

    void OnMouseDown()
    {

    }

    // Use this for initialization
    void Start()
    {
        colorOn = this.GetComponent<SpriteRenderer>().color;
        colorOff = this.GetComponent<SpriteRenderer>().color;
        colorOff.a = 0f;
        this.GetComponent<SpriteRenderer>().color = colorOff;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
