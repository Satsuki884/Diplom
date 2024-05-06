using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level
{
    public string Image;
    public string Exercise;
    public int Point;
    public string Answer;
}

public class LevelManager : MonoBehaviour
{
    private int levelNumber = LevelSelector.selectedLevel;
    public Button buttonRestart;
    public Button buttonResultRestart;

    public TextMeshProUGUI text;
    public TextMeshProUGUI exercise;

    private int range = 0;

    public Button button;
    private bool buttonPressed = false;
    public TMP_Text buttonText;

    public TMP_InputField inputfield;
    public ExitPanelController exitPanel;
    public GameObject resultPanel;
    public TMP_Text resultText;

    public Level[] levels = new Level[]
    {
        new Level
        {
            Exercise = "Запиши через пробіл числа від 20 до 30, пропускаючи кожне друге число.",
            Point = 1,
            Answer = "1"
        },
        new Level
        {
            Exercise = "Запиши через пробіл кожне п'яте число після 50 до 80.",
            Point = 1,
            Answer = "1"
        },
        new Level
        {
            Exercise = "Прослідкуй за патерном: 5, 10, 15, __, 25. Яке число йде після 15?",
            Point = 1,
            Answer = "1"
        },
        new Level
        {
            Exercise = "Запиши через пробіл числа від 60 до 70, пропускаючи кожне третє число.",
            Point = 1,
            Answer = "2"
        },
        new Level
        {
            Exercise = "Прослідкуй за патерном: 2, 4, 6, 8, __. Яке число йде після 8?",
            Point = 1,
            Answer = "1"
        },
        new Level
        {
            Exercise = "Запиши через пробіл числа від 5 до 20, пропускаючи кожне 4.",
            Point = 1,
            Answer = "1"
        },
        new Level
        {
            Exercise = "Записати через пробіл у лінію числа від меншого до більшого( 89, 13, 6, 54, 9, 61, 52, 40, 48, 12).",
            Point = 2,
            Answer = "2"
        }
    };


    private void Start()
    {
        Debug.Log(levelNumber);
        text.text = "Рівень " + levelNumber;
        resultText.text = "Рівень " + levelNumber;
        button.onClick.AddListener(ButtonPress);
        buttonRestart.onClick.AddListener(RestartOn);
        buttonResultRestart.onClick.AddListener(RestartOn);
        StartCoroutine(MyCoroutine());
       
        
    }

    public void RestartOn()
    {
        range = 0;
        exitPanel.CloseExitPanel();
        resultPanel.SetActive(false);
        Start();
    }

    IEnumerator MyCoroutine()
    {
        foreach (var item in levels)
        {
            exercise.text = item.Exercise;
            if (item == levels[levels.Length - 1])
            {
                buttonText.text = "Закінчити рівень";
            } else
            {
                buttonText.text = "Наступне питання";
            }

            yield return new WaitUntil(() => buttonPressed);
            CheckAnswer(item);

            Debug.Log("Button pressed!");
            Debug.Log(range);

            buttonPressed = false;
        }
        resultPanel.SetActive(true);
        //SceneManager.LoadScene("Game");
    }

    public void ButtonPress()
    {
        buttonPressed = true;
    }

    private void CheckAnswer(Level level)
    {
        var answer = inputfield.text;
        if(answer == level.Answer)
        {
            range += level.Point;
        }
        inputfield.text = "";
    }

    
}


