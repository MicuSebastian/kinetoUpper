using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishSphere : MonoBehaviour
{
    public int repetari = 0;
    private int a = 0;
    public GameObject canvas;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Contact was made! " + a);
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        a += 1;
    }

    void OnTriggerExit(Collider other){
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(a == repetari){
            canvas.SetActive(true);
        }
    }
}
