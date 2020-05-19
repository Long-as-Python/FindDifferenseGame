using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    Image img;
    public Transform canvas;
    public Levels[] levels;
    public Transform parent;
    public int onGoingLevel = 0;
    public int buttonCount = 0;
    public GameObject Game;
    public GameObject MainMenu;


    public void Start()
    {
        img = GetComponent<Image>();
    }

    public void Update()
    {
        if (buttonCount == 0 && onGoingLevel == levels.Length)
        {
            onGoingLevel = 0;
            Game.SetActive(false);
            MainMenu.SetActive(true);
            return;
        }
        if (buttonCount == 0 && onGoingLevel < levels.Length)
        {
            Levelloader();
            onGoingLevel++;
        }
    }

    public void Levelloader()
    {
        img.sprite = levels[onGoingLevel].sprite;
        ButtonPlacer(onGoingLevel);
        buttonCount = levels[onGoingLevel].buttons.Length;
    }

    public void ButtonCounter()
    {
        buttonCount--;
        Debug.Log("isWorking");
    }

    public void ButtonPlacer(int _onGoingLevel)
    {
        for (int i = 0; i < levels[_onGoingLevel].buttons.Length; i++)
        {
            Instantiate(levels[_onGoingLevel].buttons[i].button, canvas.position + levels[_onGoingLevel].buttons[i].buttonCoords * canvas.lossyScale.x, Quaternion.identity, canvas).onClick.AddListener(ButtonCounter);
        }
    }

    [System.Serializable]
    public class Buttons
    {
        public Vector3 buttonCoords;
        public Button button;
    }

    [System.Serializable]
    public class Levels
    {
        public Sprite sprite;
        public Buttons[] buttons;
    }
}
