using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Esteacionar : MonoBehaviour
{
    public GameObject Cubo;
    bool Esp1 = false;
    bool Esp2 = false;
    bool Esp3 = false;
    bool Esp4 = false;

    bool Victoria;

    public Text txtTime;
    public Text Estado;
    public float timeToDoSomething = 30;
    
    void start()
    {
        
    }
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
    void OnCollisionEnter(Collision col)
    {
        StartCoroutine(ExampleCoroutine());
    }

    void Update()
    {
        if (Esp1 && Esp2 && Esp3 && Esp4)
        {
            string u = "Ganaste";
            Estado.text = u;
            Reset();
        }
        float elapsedTime = Time.timeSinceLevelLoad;
        txtTime.text = elapsedTime.ToString();
        
        if (Time.time > timeToDoSomething)
        {
            StartCoroutine(ExampleCoroutine());
        }
    }

    IEnumerator ExampleCoroutine()
    {     
            string i = "Perdiste";
            Estado.text = i;
            Instantiate(Cubo);
            yield return new WaitForSeconds(3);
            Reset();
    }

    public void Reset()
    {
        SceneManager.LoadScene("SceneCopy");
        txtTime.text = "0";
    }
}

