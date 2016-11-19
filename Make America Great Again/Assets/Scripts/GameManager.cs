using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject Hillary;
    public GameObject Trump;
    bool character;
    public short LevelsCompleted = 1;
    public short lives = 3;
    public short HP = 3;
    // Use this for initialization
	void Awake () {
        DontDestroyOnLoad(this);
        LevelsCompleted = 2;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetCharacter(bool arg_character)
    {
        character = arg_character;
        SceneManager.LoadScene("StageSelect");


        switch (character)
        {
            case false:
                Hillary = GameObject.Instantiate(Hillary);
                break;
            case true:
                Trump = GameObject.Instantiate(Trump);
                break;
        }SceneManager.LoadScene("MainScene");

    }
        
}
