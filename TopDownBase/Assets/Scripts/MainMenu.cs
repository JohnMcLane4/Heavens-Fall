using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string levelToLoad = "MainLevel";

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

    public void Play()
    {
        audioManager.PlaySound(pressButtonSound);
        SceneManager.LoadScene(levelToLoad);
    }

    public void Quit()
    {
        audioManager.PlaySound(pressButtonSound);
        Debug.Log("Quit");
        Application.Quit();
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
