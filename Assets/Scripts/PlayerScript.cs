using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Vector3 kekanan;
	Vector3 kekiri;
    // Vector3 maju;
    // Vector3 mundur;
	// Vector3 keatas;
	// Vector3 kebawah;

    public int aksi;
    float speed = 7;

    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1,0,0);
		kekiri = new Vector3(-1,0,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right"))
            transform.position = transform.position + (kekanan * speed * Time.deltaTime);
        else if (Input.GetKey("left"))
            transform.position = transform.position + (kekiri * speed * Time.deltaTime);
        else if(Input.GetKey("d"))
            transform.position = transform.position + (kekanan * speed * Time.deltaTime);
        else if (Input.GetKey("a"))
            transform.position = transform.position + (kekiri * speed * Time.deltaTime);
        
    }
}
