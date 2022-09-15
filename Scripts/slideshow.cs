using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class slideshow : MonoBehaviour
{
    public Image original;
    private int currentImg;

    public List<Sprite> lista = new List<Sprite>();

    int a = 0;
    int b = 0;
    int c = 0;
    
    public void ChangeImgNext(){
        a += 1;
        if(a == lista.Count){
            a = 0;
        }
        original.sprite = lista[a];
        b = a;
    }

    public void ChangeImgPrev(){
        a -= 1;
        if(a == -1){
            a = lista.Count - 1;
        }
        original.sprite = lista[a];
        b = a;
    }

    public void PlayGame(){
        c = b + 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + c);
    }
}
