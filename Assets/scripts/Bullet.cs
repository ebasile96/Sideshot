using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour {

    public Rigidbody rb;
    public float bulletVelocity = 0f;
    public Color actualColor;

	// Use this for initialization
	void Start ()
    {

        rb = GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {

        rb.velocity = transform.TransformDirection(Vector3.up * bulletVelocity);
	}

    void OnTriggerEnter(Collider other)
    {

        switch (actualColor)
        {
            case Color.Green:
                if (other.tag == "Green" && this.gameObject.tag == "Green")
                {
                    Destroy(other.gameObject);
                }
                else
                {
                    Debug.Log("You lost");
                    LoadA();
                }break;

            case Color.Red:
                if (other.tag == "Red" && this.gameObject.tag == "Red")
                {
                    Destroy(other.gameObject);
                }
                else
                {
                    Debug.Log("You lost");
                    LoadA();
                }
                break;

            case Color.Yellow:
                if (other.tag == "Yellow" && this.gameObject.tag == "Yellow")
                {
                    Destroy(other.gameObject);
                }
                else
                {
                    Debug.Log("You lost");
                    LoadA();
                }
                break;

        }
       

         Destroy(this.gameObject);
    }

    public enum Color
    {
        Green,
        Red,
        Yellow
    }


   public void LoadA()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
