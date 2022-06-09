using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esteacionar : MonoBehaviour
{
    public GameObject espacio;
    bool Esp1 = false;
    bool Esp2 = false;
    bool Esp3 = false;
    bool Esp4 = false;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Espacio")
        {
            Esp1 = true;
            Debug.Log("1");
        }
        if (collision.gameObject.name == "Espacio (1)")
        {
            Esp2 = true;
            Debug.Log("2");
        }
        if (collision.gameObject.name == "Espacio (2)")
        {
            Esp3 = true;
            Debug.Log("3");
        }
        if (collision.gameObject.name == "Espacio (3)")
        {
            Esp4 = true;
            Debug.Log("4");
        }
    }
    void Update()
    {
        if (Esp1 && Esp2 && Esp3 && Esp4)
        {
            Debug.Log("Esa");
        }
    }
}

