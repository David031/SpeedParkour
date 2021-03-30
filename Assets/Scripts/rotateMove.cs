using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateMove : MonoBehaviour
{
   public GameObject player;
   public GameObject plane;
    // Start is called before the first frame update
    bool isTouch = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isTouch);
        if(isTouch == true){
            player.transform.SetParent(plane.transform);
        }else{
            player.transform.SetParent(null);
        }
    }

    private void OnCollisionEnter(Collision other) {
        // if(other.gameObject.tag == "Player"){
            isTouch = true;
        // }
         Debug.Log("Touch");
    }
    private void OnCollisionExit(Collision other) {
            //  if(other.gameObject.tag == "Player"){
            isTouch = false;
        // }
        Debug.Log("Exit");
    }
    private void OnTriggerEnter(Collider other) {
        // if(other.gameObject.tag == "Player"){
            isTouch = true;
        // }
         Debug.Log("TT Touch");
    }
    private void OnTriggerExit(Collider other) {
            //  if(other.gameObject.tag == "Player"){
            isTouch = false;
        // }
        Debug.Log("TT Exit");
    }
    private void OnTriggerStay(Collider other)
    {
    Debug.Log("stay");
    }
}
