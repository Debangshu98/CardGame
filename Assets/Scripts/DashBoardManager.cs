using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DashBoardManager : MonoBehaviour
{
    [SerializeField] private Button startBtn;
    [SerializeField] private Button signOutBtn;
    [SerializeField] private GameObject soundBtn;
    [SerializeField] private Button creditsBtn;
    [SerializeField] private Button quitBtn;
    [SerializeField] private Button backBtn;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Sprite musicOn;
    [SerializeField] private Sprite musicOff;
    [SerializeField] private GameObject creditScreen;
    public static bool isSound;

    private void Start()
    {
        isSound = true;
        startBtn.onClick.AddListener(StartGame);
        quitBtn.onClick.AddListener(QuitGame);
        signOutBtn.onClick.AddListener(SignOut);
        soundBtn.GetComponent<Button>().onClick.AddListener(CheckSound);
        creditsBtn.onClick.AddListener(SwitchOnCredit);
        backBtn.onClick.AddListener(SwitchOffCredit);
    }

    /// <summary>
    /// this function just quits the game 
    /// </summary>
    void QuitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// this function starts the game
    /// </summary>
    void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// this function loads the login scene
    /// </summary>
    void SignOut()
    {
        SceneManager.LoadScene(0);
    }

    /// <summary>
    /// this function just checks the bg music
    /// </summary>
    void CheckSound()
    {
        if (isSound)
        {
            audioSource.Pause();
            soundBtn.GetComponent<Image>().sprite = musicOff;
        }
        else
        {
            audioSource.Play();
            soundBtn.GetComponent<Image>().sprite = musicOn;
        }

  
    }

    /// <summary>
    /// this function just shows the credit screen
    /// </summary>
    void SwitchOnCredit()
    {
        creditScreen.SetActive(true);
    }

    /// <summary>
    /// this function just hides the credit screen
    /// </summary>
    void SwitchOffCredit()
    {
        creditScreen?.SetActive(false);
    }
}
