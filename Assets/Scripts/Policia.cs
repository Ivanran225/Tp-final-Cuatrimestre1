using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Policia : MonoBehaviour
{
    public Vector3 playerPosition;
    public float rotationSpeed;
    public float movementSpeed = 0.3f;

    void Start()
    {
        playerPosition = transform.position + new Vector3(0, 1, 0);
    }

    void Update()
    {
        transform.position += new Vector3(-movementSpeed, 0, 0);

        if (transform.position.x == -200)
        {
            transform.position = new Vector3(150, 50, 80);
        }
    }
}