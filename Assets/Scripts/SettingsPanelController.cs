using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SettingsPanelController : MonoBehaviour
{
    public GameObject settingsPanel;

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
            if (settingsPanel.activeSelf && !RectTransformUtility.RectangleContainsScreenPoint(settingsPanel.GetComponent<RectTransform>(), Input.mousePosition) && !IsPointerOverUIObject())
            {
                CloseSettingsPanel();
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

    public void OpenSettingsPanel()
    {
        // Открываем панель выхода
        settingsPanel.SetActive(true);
    }

    public void CloseSettingsPanel()
    {
        // Закрываем панель выхода
        settingsPanel.SetActive(false);
    }
}
