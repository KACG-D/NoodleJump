using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

    void Start (){
        }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("当たった");
        if (other.gameObject.tag == "Menma")
        {
            Destroy(other.gameObject);
        }
    }
}
