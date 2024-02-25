using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Text soldiersInHelicopterText;
    public Text soldiersRescuedText;
    public Text gameOverText;
    public Text youWinText;

    private int soldiersRescued = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateSoldiersInHelicopter(int count)
    {
        soldiersInHelicopterText.text = "Soldiers in Helicopter: " + count;
    }

    public void IncrementSoldiersRescued()
    {
        soldiersRescued++;
        soldiersRescuedText.text = "Soldiers Rescued: " + soldiersRescued;

        if (soldiersRescued >= 10)
        {
            YouWin();
        }
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

    public void YouWin()
    {
        youWinText.gameObject.SetActive(true);
    }
}
