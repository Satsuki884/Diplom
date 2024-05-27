using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{

    public int level;
    public static int selectedLevel;


    void Start()
    {
        // levelText.text = level.ToString();
    }

    public void OpenScene(string typeLevel)
    {
        selectedLevel = level;
        Debug.Log(typeLevel);
        if(typeLevel == "quest")
        {
            SceneManager.LoadScene("UniversalLevel");
        } 
        /*else if(typeLevel == "table")
        {
            SceneManager.LoadScene("UniversalLevelTable");
        }*/
        else if (typeLevel == "check")
        {
            SceneManager.LoadScene("UniversalLevelCheck");
        }

    }
}
