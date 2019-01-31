using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour {

    public GameObject coll, coll1, coll2;
    
    

    void Start()
    {
        coll.GetComponentInChildren<BoxCollider>();
        coll1.GetComponentInChildren<BoxCollider>();
        coll2.GetComponentInChildren<BoxCollider>();
    }

	
	// Update is called once per frame
	void Update () {

        YouWin();
		
	}

    void YouWin()
    {
        if (coll == false && coll1 == false && coll2 == false)
        {
            Debug.Log("You Win");
            LoadNext();
        }
    }

    public void LoadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
