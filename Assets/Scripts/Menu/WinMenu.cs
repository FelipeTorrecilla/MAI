using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject winMenu;
    public GameObject gameManager;
    public static bool isPaused;


    void Start()
    {
        winMenu.SetActive(false);
    }

private void OnCollisionEnter2D(Collision2D other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        EndGame();
    }
}


public void EndGame()
{
    winMenu.SetActive(true);
    Time.timeScale = 0f;
    isPaused = true;
    gameManager.SetActive(false);
}

public void GoToMainMenu()
{
    Time.timeScale = 1f;
    isPaused = false;
    gameManager.SetActive(true);
    SceneManager.LoadScene("Menu");
}

public void QuitGame()
{
    Application.Quit();
}


}
