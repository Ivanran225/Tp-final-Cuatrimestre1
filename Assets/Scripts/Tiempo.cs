using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo: MonoBehaviour
{
    public Text txtTime;

    public float customTime;
    public bool isCounting;
    public float timeToDoSomething = 30;
    public float timeToWait;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        txtTime.text = elapsedTime.ToString();

        if (Time.time > timeToDoSomething)
        {
            Debug.Log("Hacer algo");
        }
    }
}                                                                                          