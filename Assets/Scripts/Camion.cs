using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camion : MonoBehaviour
{
    public Vector3 playerPosition;
    public float rotationSpeed;
    public float movementSpeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = transform.position + new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-movementSpeed, 0, 0);
        //
        //transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
        //transform.localScale += new Vector3(0.1f, 0, 0);
        if (transform.position.x == -200)
        {
            transform.position = new Vector3(18, 49.5f, 80);
        }
    }
}