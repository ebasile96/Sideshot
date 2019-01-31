using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour {

    public GameObject prefab1, prefab2, prefab3;
    public Rigidbody rb;
    public float BulletSpeed = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckInput();
	}

    void CheckInput()
    {
        if (Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab1, transform.position, transform.rotation);
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab2, transform.position, transform.rotation);
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab3, transform.position, transform.rotation);
        }
    }
}
