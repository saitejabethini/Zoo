using UnityEngine;
using System.Collections;

public class AnimeDragon : MonoBehaviour {

    public Animator a;
    // Use this for initialization
    void Start()
    {
        a = GetComponent<Animator>();
        //a.enabled = false;

    }

    void Update()
    {
        a.Play("Armature|Fly_New");

    }

}
