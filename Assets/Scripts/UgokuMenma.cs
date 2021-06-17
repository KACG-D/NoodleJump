using UnityEngine;
using System.Collections;

public class UgokuMenma : MonoBehaviour {

    public float CameraSize;
    public float maxSpeedX;
    public float MenmaSize;
    float SpeedX;
    float Width;
    int direction = -1;
    void Start()
    {
        Width = CameraSize * Camera.main.aspect-MenmaSize/2;
        SpeedX = Random.Range(0.3f, maxSpeedX);
    }
	// Update is called once per frame
	void Update () {
        if (transform.position.x * direction < Width)
        {
            transform.Translate(new Vector3(direction*SpeedX,0,0));
        }
        else {
            direction *= -1;
        }
	}
}
