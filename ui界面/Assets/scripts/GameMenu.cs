using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameMenu : MonoBehaviour
{

    public void OnStart()
    {
        SceneManager.LoadScene("Game1");
    }
    public void OnExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
    }
    public void OnInformation()
    {
        SceneManager.LoadScene("Information");
    }
    public void OnChoice()
    {
        SceneManager.LoadScene("Choice");
    }
    public void OnSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void OnReturn()
    {
        SceneManager.LoadScene("Start");
    }
    public void OnGame1()
    {
        SceneManager.LoadScene("Game1");
    }
    public void OnGame2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void OnGame3()
    {
        SceneManager.LoadScene("Game3");
    }
    public void OnGame4()
    {
        SceneManager.LoadScene("Game4");
    }
    public void OnGame5()
    {
        SceneManager.LoadScene("Game5");
    }
}
