using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        Debug.Log("Contact was made!");
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        
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
        
    }
}
