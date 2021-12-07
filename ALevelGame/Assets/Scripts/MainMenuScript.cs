using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    
    public GameObject MainMenu;
    public GameObject InstructionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        InstructionsMenu.SetActive(false);
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Room Generating");
    }

    public void InstructionsButton()
    {
        // Show Credits Menu
        MainMenu.SetActive(false);
        InstructionsMenu.SetActive(true);
    }

    

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}

