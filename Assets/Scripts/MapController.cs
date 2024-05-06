using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{

    private GameObject[] levels;
    private GameObject[] bosses;
    private int level = BinaryFileUtility.ReadNumberFromFile();

    public Scrollbar scrollbar;
    public RectTransform containerRectTransform;

    private void Start()
    {
        levels = GameObject.FindGameObjectsWithTag("Level");
        Array.Sort(levels, CompareObjectNames);
        bosses = GameObject.FindGameObjectsWithTag("BossLevel");
        Array.Sort(bosses, CompareObjectNames);
        Debug.Log(levels.Length);
        Debug.Log(bosses.Length);
        ScrollTo();
    }
    private int CompareObjectNames(GameObject a, GameObject b)
    {
        // Сравниваем имена объектов
        return a.name.CompareTo(b.name);
    }

    public void ScrollTo()
    {
        var targetObject = levels[level-1];
        Vector3 targetLocalPosition = containerRectTransform.InverseTransformPoint(targetObject.transform.position);

        // Получаем максимальное и минимальное значение позиции контейнера
        float contentHeight = containerRectTransform.rect.height;
        float targetYPosition = Mathf.Clamp(targetLocalPosition.y, 0, contentHeight);

        // Нормализуем значение позиции относительно высоты контейнера
        float normalizedPosition = targetYPosition / contentHeight;

        // Устанавливаем новую позицию для Scrollbar'а
        scrollbar.value = 1 - normalizedPosition;
    }
}
