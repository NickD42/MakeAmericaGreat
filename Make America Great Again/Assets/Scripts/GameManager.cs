using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool character;
    short LevelsCompleted;
    // Use this for initialization
	void Awake () {
        DontDestroyOnLoad(transform.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public
    void SetCharacter(bool arg_character)
    {
        character = arg_character;
        SceneManager.LoadScene("MainScene");
    }
}
