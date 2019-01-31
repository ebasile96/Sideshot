using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TringleRotation : MonoBehaviour
{

    public float SpeedRotation = 0f;

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        transform.Rotate(0, 0, (Time.deltaTime * SpeedRotation));
    }
}
