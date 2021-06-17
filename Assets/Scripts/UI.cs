using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public GameObject retrybutton;
    public Text scoreLabel;
    public void BacktoTitle() {
        Application.LoadLevel("Title");
    }

    public void GameOver()
    {
        retrybutton.SetActiveRecursively(true);
    }
    public void Reload() {
        Application.LoadLevel(Application.loadedLevel);
    }

	void Start()
    {
        retrybutton.SetActiveRecursively(false);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
    public void rescore(int score)
    {
        scoreLabel.text = "Score : " + score;
    }
}
