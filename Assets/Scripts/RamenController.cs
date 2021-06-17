using UnityEngine;
using System.Collections;

public class RamenController : MonoBehaviour {
    float startpoint;
    float endpoint;
    public bool fall = false;

    public float speedX;
    public float CameraSize;
    public int ramenNo;
    public Rigidbody2D rgd;
    public GameObject spr;
    public float veloy;

    Collider2D cold;
    AudioSource jumpSE;
    
    

	void Start () {
        jumpSE = GetComponent<AudioSource>();
        startpoint = Camera.main.aspect * CameraSize*2;
        endpoint = -1 * Camera.main.aspect * CameraSize*2;
        transform.Translate(ramenNo * startpoint,0,0);
        cold = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {

        float x=0;
        if (rgd.velocity.y < 0)
        {
            cold.enabled=(true);
        }
        else cold.enabled=(false);
        if (fall) return;
        if (transform.position.y < Camera.main.transform.position.y-CameraSize)
        {
            Gameover();
        }
        //if (Input.GetButton("Fire1")) x = ((Input.mousePosition.x - Screen.width / 2) / Screen.width / 2);
        
        if (Application.isEditor) x = Input.GetAxis("Horizontal");

        else  x = Input.acceleration.x;

        transform.Translate(new Vector3(x * speedX, 0, 0));
        Vector3 scale = spr.transform.localScale;
        if (x > 0.1f)
        {
            // 右方向に移動中
            scale.x = -1; 
        }
        else if(x < -0.1f)
        {
            // 左方向に移動中
            scale.x = 1; 
        }

        spr.transform.localScale = scale;
        if (transform.position.x > startpoint) {
            transform.Translate((endpoint - startpoint), 0, 0);
        } 
        if (transform.position.x < endpoint) transform.Translate(-1*(endpoint - startpoint), 0, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Menma")
        {
            
                rgd.velocity = new Vector2(0, veloy);
                jumpSE.Play();
            
        }
        

    }
    
    void Gameover()
    {
        fall = true;
    }
    
    
}
