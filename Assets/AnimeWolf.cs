using UnityEngine;
using System.Collections;

public class AnimeWolf : MonoBehaviour {

    public Animator a;
    // Use this for initialization
    void Start()
    {
        a = GetComponent<Animator>();
        //a.enabled = false;

    }

    void Update()
    {
        a.Play("Wolf_Skeleton|Wolf_Run_Cycle_");

    }

}
