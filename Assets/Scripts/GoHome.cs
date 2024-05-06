using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour
{
    public void MoveToScene(int sceneID)
    {
        Debug.Log(LevelSelector.selectedLevel);
        BinaryFileUtility.WriteNumberToFile(LevelSelector.selectedLevel);
        SceneManager.LoadScene(sceneID);

    }
}
