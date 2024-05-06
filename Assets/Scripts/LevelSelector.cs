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

    public void OpenScene()
    {
        selectedLevel = level;
        SceneManager.LoadScene("UniversalLevel");

    }
}
