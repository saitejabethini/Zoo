using UnityEngine;
using System.Collections;
using System;
using System.Timers;

public class Anime : MonoBehaviour
{

    public GameObject[] a;
    GameObject selectedGO;
    // Use this for initialization
    void Start()
    {
        selectedGO = new GameObject();

    }

    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects ex      


         //cluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            //Debug.Log("Did Hit"+ hit.collider.gameObject);
            selectedGO = hit.collider.gameObject;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            //Debug.Log("Did not Hit");
            selectedGO = null;
        }


        if (selectedGO != null)
        {
            Animator anim = selectedGO.GetComponent<Animator>();
            StartCoroutine(WaitForAnime(anim));

        }
    }

    private IEnumerator WaitForAnime(Animator anim)
    {

        anim.SetInteger("state", 0);
        anim.SetTrigger("makeTransition");
        yield return new WaitForSeconds(1000);
    }
}