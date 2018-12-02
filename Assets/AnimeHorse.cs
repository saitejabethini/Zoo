using UnityEngine;
using System.Collections;

public class AnimeHorse : MonoBehaviour {
    public Animator a;
    // Use this for initialization
    void Start()
    {
        a = GetComponent<Animator>();
        //a.enabled = false;

    }

    void Update()
    {
        a.Play("Horse_Run");

    }

}
