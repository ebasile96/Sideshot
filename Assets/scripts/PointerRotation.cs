using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerRotation : MonoBehaviour {

    public float SpeedRot = 0f;
    //public TringleRotation Triangle;
    public GameObject form;

    private void Start()
    {
      //Triangle = FindObjectOfType<TringleRotation>();
    }

    // Update is called once per frame
    void Update ()
    {
        PointRotation();
	}

    void PointRotation()
    {
        transform.RotateAround(form.transform.position, new Vector3(0, 0, 1), -SpeedRot * Time.deltaTime);
    }
}
