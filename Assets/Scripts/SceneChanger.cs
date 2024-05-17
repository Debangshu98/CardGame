using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private Button sceneChangeBtn;

    /// <summary>
    /// this function just changes the scene as per its parameter
    /// </summary>
    /// <param name="index"></param>
    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
