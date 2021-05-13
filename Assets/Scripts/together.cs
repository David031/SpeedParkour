using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class together : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject plane;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.SetParent(plane.transform);
        }
        Debug.Log("Touch");
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.SetParent(null);
        }
        Debug.Log("Exit");
    }
}
