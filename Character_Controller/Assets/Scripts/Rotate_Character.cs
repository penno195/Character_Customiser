using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Character : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        if (Colour_Change.Rotate_Off == true)
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        

    }
}
