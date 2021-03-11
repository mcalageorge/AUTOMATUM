using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UICLICKS : MonoBehaviour
{
    public void LoadConstructor()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene(2);
    }
    public void ApplicationExit()
    {
        Application.Quit();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
