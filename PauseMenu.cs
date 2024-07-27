using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Text Counter;
    public static bool isPaused = false;
    public static bool startOver = false;
    public GameObject pauseMenu;
    public AudioSource backgorundmusic;
    
    void Start()
    {
        AudioSource backgroundmusic = GetComponent<AudioSource>();
        startOver = false;
    }

    //void Update()
    //{
            //if(isPaused)
            //{
                //Resume();
            //}
            //else
            //{
                //Paused();
            //}
          
    //}

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        backgorundmusic.volume = 1f;
    }

    public void Paused()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Resume();
    }

    public void PlayAgain()
    {
        startOver = true;
        Counter.color = new Color(1f, 1f, 1f, 0f);
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        ScoreScript.scoreValue = 0;
        Time.timeScale = 1f;
    }
}
