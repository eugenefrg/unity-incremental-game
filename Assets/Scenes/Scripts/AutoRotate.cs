using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float xSpeed = 0;
    public float ySpeed = 25;
    public float zSpeed = 0;
    void Update()
    {
        transform.Rotate(
             xSpeed * Time.deltaTime,
             ySpeed * Time.deltaTime,
             zSpeed * Time.deltaTime
        );
    }

}
