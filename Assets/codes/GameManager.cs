using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void retrybutton()
    {
        
        
        AsyncOperation async = SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;

    }

}
