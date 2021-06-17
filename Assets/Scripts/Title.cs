using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Title : MonoBehaviour {
    public Ranking ranking;
	
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        ranking.Set();
    }
    public void GameStart()
    {
        Application.LoadLevel("Main");
    }
}
