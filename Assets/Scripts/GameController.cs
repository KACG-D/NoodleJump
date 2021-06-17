using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
    AudioSource fall;

    enum State
    {
        Ready,
        Play,
        GameOver
    }
    State state;
    public int score=0;
    public Ranking ranking;
    public RamenController ramen;
    public Cameramover camera;
    public UI ui;
    public NewRecord newrecord;


    void Start ()
    {
        newrecord.gameObject.SetActive(false);
        fall = GetComponent<AudioSource>();
        state = State.Play;
    }
	
	// Update is called once per frame
	void Update () {
        if (state==State.Play&&ramen.fall) GameOver();
        if (state == State.GameOver)
        {
            
            
        }
        if (score < (int)transform.position.y) {
            score = (int)transform.position.y;
            ui.rescore(score);
        } 
	}

    void GameOver() {
        fall.Play();
        state = State.GameOver;
        camera.GameOver = true;
        newrecord.enabled = true;
        if (score >= PlayerPrefs.GetInt("HighScore3"))
        {
            newrecord.gameObject.SetActive(true);
            newrecord.Set();
            newrecord.enabled = true;
        }
        else RankingV();

        
    }
    public void RankingV()
    {
        ui.GameOver();
        ranking.Set();
    }

}
