using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewRecord : MonoBehaviour {
    public Text NewScore;
    public InputField Name;
    private int Score=0;
    private string name="";
    public GameController GC;
    void Start() {
        enabled = false;
        
    }

    public void Set()
    {
        Score = GC.score;
        NewScore.text = Score.ToString();

    }
    public void GetName() {
        name = Name.text;
        Retu();
    }

    public void Retu()
    {
        if (Score >= PlayerPrefs.GetInt("HighScore1"))
        {
            PlayerPrefs.SetInt("HighScore3", PlayerPrefs.GetInt("HighScore2"));
            PlayerPrefs.SetInt("HighScore2", PlayerPrefs.GetInt("HighScore1"));
            PlayerPrefs.SetInt("HighScore1", Score);
            PlayerPrefs.SetString("HighName3", PlayerPrefs.GetString("HighName2"));
            PlayerPrefs.SetString("HighName2", PlayerPrefs.GetString("HighName1"));
            PlayerPrefs.SetString("HighName1", name);
        }
        else if (Score >= PlayerPrefs.GetInt("HighScore2"))
        {
            PlayerPrefs.SetInt("HighScore2", PlayerPrefs.GetInt("HighScore1"));
            PlayerPrefs.SetInt("HighScore2", Score);

            PlayerPrefs.SetString("HighName3", PlayerPrefs.GetString("HighName2"));
            PlayerPrefs.SetString("HighName2", name);
        }
        else if (Score >= PlayerPrefs.GetInt("HighScore3"))
        {
            PlayerPrefs.SetInt("HighScore3", Score);
            PlayerPrefs.SetString("HighName3", name);
        }
        GC.RankingV();
        gameObject.SetActive(false);
    }


}
