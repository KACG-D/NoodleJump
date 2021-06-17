using UnityEngine;
using System.Collections;

public class MenmaDestroyer : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other)
    {
       

        if (other.gameObject.tag == "Menma"|| other.gameObject.tag == "Wareta Menma")
        {
            Destroy(other.gameObject);
        }


    }
}
