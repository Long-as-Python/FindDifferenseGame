using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject Game;
    public GameObject MainMenu;


    public void PlayGame()
    {
        Game.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void QuitGame()
    {

    }
}
