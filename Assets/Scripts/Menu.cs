using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Main()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void exitgame()
    {
        Application.Quit();
    }
}
