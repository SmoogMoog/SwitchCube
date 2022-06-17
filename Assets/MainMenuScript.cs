using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;
    public string gameSceneName;
    public GameObject loadGameMenu;
    void Start()
    {
        
    }
    public void OpenLoadGameMenu()
    {
        loadGameMenu.SetActive(true);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("trying to exit game. Don't panic");
    }
}
