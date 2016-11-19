using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject Hillary;
    public GameObject Trump;
    bool character;
    short LevelsCompleted;
    // Use this for initialization
	void Awake () {
        DontDestroyOnLoad(this);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetCharacter(bool arg_character)
    {
        character = arg_character;


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
