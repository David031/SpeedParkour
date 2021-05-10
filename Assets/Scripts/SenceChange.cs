using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartLevel()
    {
        SceneManager.LoadScene("Level1");
    }
    public void FinsihLevel()
    {
        SceneManager.LoadScene("FinishMenu");
    }
    public void ReatartGame()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
