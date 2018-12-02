//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.EventSystems;
//public class ObtBehaviourScript : MonoBehaviour {

//    private float timer;
//    private float gazeTime = 3f;
//    private bool gazedAt;
//	// Use this for initialization
//	void Start () {
	
//	}
	
//	// Update is called once per frame
//	void Update () {
	
//        if(gazedAt){

//            timer += gazeTime.;

//            if(timer >= gazeTime){

//                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
//                timer = 0f;
//            }
//        }

//	}

//    public void PointerEnter(){
//        gazedAt = true;
//    }

//    public void PointerExit(){

//        gazedAt = false;
//    }

//    public void PointerDown() {

//    }
//}
