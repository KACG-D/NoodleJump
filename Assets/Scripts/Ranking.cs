using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ranking : MonoBehaviour {
    public Text r,R1, R2, R3;
    void Start() {
        r.enabled = false;
        R1.enabled = false;
        R2.enabled = false;
        R3.enabled = false;
    }

	public void Set () {
        r.enabled = true;
        R1.enabled = true;
        R2.enabled = true;
        R3.enabled = true;
        R1.text = "1位　" + PlayerPrefs.GetString("HighName1") + "　" + PlayerPrefs.GetInt("HighScore1");
        R2.text = "2位　" + PlayerPrefs.GetString("HighName2") + "　" + PlayerPrefs.GetInt("HighScore2");
        R3.text = "3位　" + PlayerPrefs.GetString("HighName3") + "　" + PlayerPrefs.GetInt("HighScore3");
    }
}
