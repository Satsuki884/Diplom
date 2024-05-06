using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UniversalLevelManager : MonoBehaviour
{
    public Sprite[] backgrounds;
    public Image background;
    // public Text text;


    private void Start()
    {
        int level = LevelSelector.selectedLevel;

        Debug.Log(level);
        Debug.Log(backgrounds.Length);

        // text.text = "Level " + level.ToString();

        if (level >= 1 && level <= 17)
        {
            // background.sprite = Resources.Load<Sprite>("LevelBack/level1");
            background.sprite = backgrounds[0];
        }
        else if (level >= 19 && level <= 30)
        {
            // background.sprite = Resources.Load<Sprite>("LevelBack/level2");
            background.sprite = backgrounds[1];
        }
        else if (level >= 32 && level <= 33)
        {
            // background.sprite = Resources.Load<Sprite>("LevelBack/level3");
            background.sprite = backgrounds[2];
        }
        else if (level >= 35 && level <= 43)
        {
            // background.sprite = Resources.Load<Sprite>("LevelBack/level4");
            background.sprite = backgrounds[3];
        }
        else if (level >= 45 && level <= 57)
        {
            // background.sprite = Resources.Load<Sprite>("LevelBack/level5");
            background.sprite = backgrounds[4];
        }
        else if (level >= 58 && level <= 67)
        {
            // background.sprite = Resources.Load<Sprite>("LevelBack/level6");
            background.sprite = backgrounds[5];
        }


    }

    public void GoBackToGameMenu()
    {
        SceneManager.LoadScene("Game");
    }
}
