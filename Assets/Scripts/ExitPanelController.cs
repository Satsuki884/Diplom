using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ExitPanelController : MonoBehaviour
{
    public GameObject exitPanel;

    public void Start()
    {
        Input.simulateMouseWithTouches = true; // Для обработки касаний на мобильных устройствах
        TouchScreenKeyboard.hideInput = true; // Чтобы скрыть виртуальную клавиатуру на мобильных устройствах
    }

    public void Update()
    {
        // Если пользователь нажал на экран
        if (Input.GetMouseButtonDown(0))
        {
            // Проверяем, что панель открыта и касание было за её пределами
            if (exitPanel.activeSelf && !RectTransformUtility.RectangleContainsScreenPoint(exitPanel.GetComponent<RectTransform>(), Input.mousePosition) && !IsPointerOverUIObject())
            {
                CloseExitPanel();
            }
        }
    }

    public bool IsPointerOverUIObject()
    {
        // Проверяем, попадает ли точка касания на элемент UI
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }

    public void OpenExitPanel()
    {
        // Открываем панель выхода
        exitPanel.SetActive(true);
    }

    public void ExitGame()
    {
        // Выходим из игры
        Application.Quit();
    }

    public void CloseExitPanel()
    {
        // Закрываем панель выхода
        exitPanel.SetActive(false);
    }
}
