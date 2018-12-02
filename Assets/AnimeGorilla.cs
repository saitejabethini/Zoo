using UnityEngine;
using System.Collections;

public class AnimeGorilla : MonoBehaviour {

    public Animator a;

    void Start()
    {
        a = GetComponent<Animator>();
        //a.enabled = false;

    }
   


    void Update()
    {
        a.Play("Howl");

    }


}
