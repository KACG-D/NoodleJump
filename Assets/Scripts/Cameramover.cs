using UnityEngine;
using System.Collections;

public class Cameramover : MonoBehaviour {
    float maxheight;

    public GameObject Ramen;
    public bool GameOver;
    public float fallspeed;
    public float CameraSize;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (GameOver) {
            if(transform.position.y > maxheight - CameraSize * 2-1) transform.Translate(new Vector3(0,-fallspeed,0));
            
        }
            
        else if (Ramen.transform.position.y > transform.position.y )
        {
            transform.position = new Vector3(0, Ramen.transform.position.y, -10);
            maxheight = transform.position.y;
        }
    }
}
