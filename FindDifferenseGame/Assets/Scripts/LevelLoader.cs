using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{

    Image img;
    public Levels[] levels;
    public Transform parent;


    void Start()
    {
        img = GetComponent<Image>();
        img.sprite = levels[0].sprite;
        Instantiate(levels[0].buttons.button, Vector3.zero, Quaternion.identity).transform.SetParent(parent);

    }

    [System.Serializable]
    public class Buttons
    {
        public float coordX;
        public float coordY;
        public Button button;
    }

    [System.Serializable]
    public class Levels
    {
        public Sprite sprite;
        public Buttons buttons;
    }
}
