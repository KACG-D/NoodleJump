using UnityEngine;
using System.Collections;

public class WaretaMenma : MonoBehaviour {
    Rigidbody2D rgd;
    public GameObject left;
    public GameObject right;
    AudioSource saku;
    bool wareta;
    void Start()
    {
        saku = GetComponent<AudioSource>();
        rgd = GetComponent<Rigidbody2D>();
    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(!wareta)if (other.gameObject.tag == "Player")
        {
            left.transform.eulerAngles=(new Vector3(0, 0, 45));
            right.transform.eulerAngles = (new Vector3(0, 0, -45));
            
            saku.Play();
            rgd.gravityScale = 1;
            wareta = true;
        }


    }



}
