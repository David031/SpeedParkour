using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Door Open");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("FinishMenu");
        Debug.Log("Finish");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
