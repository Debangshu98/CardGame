using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCardGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> cards = new List<GameObject>();
    [SerializeField] private List<Vector3> cardPos = new List<Vector3>();
    [SerializeField] private Transform cardParent;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private Button cardButton;
    [SerializeField] private Text scoreTxt;
    int cardCounter = 0;
    int totalScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (DashBoardManager.isSound)
        {
            AudioManager.instance.PlayBgMusic();
        }
        cardButton.onClick.RemoveAllListeners();
        cardButton.onClick.AddListener(GenerateCard);
    }

    /// <summary>
    /// this function actually generates a random card
    /// </summary>
    public void GenerateCard()
    {
        AudioManager.instance.PlayAudioClip();
        GameObject obj = Instantiate(cards[0]);
        int score = obj.GetComponent<CardDetails>().point;
        totalScore += score;
        scoreTxt.text = totalScore + "";
        if (cardCounter <= 2)
        {
            obj.transform.position = cardPos[cardCounter];
            cardCounter++;
        }
        else
        {
            Debug.Log("No more Cards");
            if (totalScore > 26)
            {
                winPanel.SetActive(true);
            }
            else
            {
                losePanel.SetActive(true);
            }
        }
        Shuffle(cards);
    }

    /// <summary>
    /// this function shuffles the list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    void Shuffle<T>(List<T> list)
    {
        System.Random rng = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
