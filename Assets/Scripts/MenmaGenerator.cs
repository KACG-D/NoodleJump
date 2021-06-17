using UnityEngine;
using System.Collections;

public class MenmaGenerator : MonoBehaviour {
    public float maxHeight;
    public float CameraSize;
    public GameObject[] Menmaprefab;
    public float menmaX;
    float width;
    float nextheight;
	
	void Start () {
        width = CameraSize * Camera.main.aspect;
        nextheight = transform.position.y;
        
            
        
    }
	
	void Update () {
        if (nextheight < transform.position.y)
        {
            GenerateMenma();
        }
	}

    void GenerateMenma()
    {
        int i=0;
        if (Menmaprefab.Length != 1) i = (int)Random.Range(0f,2.8f * MaxHeight());
        Debug.Log(i);
        float x = Random.Range(-width + menmaX / 2, width - menmaX / 2);
        GameObject Menma = (GameObject)Instantiate(Menmaprefab[i], transform.position + new Vector3(x, 0, 0), Quaternion.identity);
        nextheight = transform.position.y + Random.Range(0, MaxHeight() * maxHeight);
    }

    float MaxHeight()
    {
        float height;
        if (transform.position.y < 700) height = transform.position.y / 1000;
        else height = 0.7f;
        height += 0.3f;
        return height;
        
    }
}
