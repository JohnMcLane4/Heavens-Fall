using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {

    public bool gamePaused = false;
    public GameObject pauseMenu;

    public string levelToLoad = "MainMenu";

    [SerializeField]
    string hoverOverSound = "HoverSound";

    [SerializeField]
    string pressButtonSound = "PressButton";

    AudioManager audioManager;


    public void Start()
    {
        audioManager = AudioManager.instance;
        if (audioManager == null)
        {
            Debug.LogError("No AudioManager!");
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused == false)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

    void Resume()
    {
        Time.timeScale = 0;
        gamePaused = true;
        pauseMenu.SetActive(true);
    }

    void Pause()
    {
        pauseMenu.SetActive(false);
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void Play()
    {
        audioManager.PlaySound(pressButtonSound);
        SceneManager.LoadScene(levelToLoad);
        pauseMenu.SetActive(false);
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void OnMouseOver()
    {
        audioManager.PlaySound(hoverOverSound);
    }

    public void OnMouseClick()
    {
        audioManager.PlaySound(pressButtonSound);
    }
}
