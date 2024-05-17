using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    [SerializeField] private Button quitButton;

    private void Start()
    {
        quitButton.onClick.AddListener(GameQuit);
    }


    /// <summary>
    /// this function quits the game
    /// </summary>
    void GameQuit()
    {
        Application.Quit();
    }
}
