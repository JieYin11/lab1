using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Text soldiersInHelicopterText;
    public Text soldiersRescuedText;
    public Text gameOverText;
    public Text youWinText;
    public KeyCode resetKey = KeyCode.R;

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

        if (soldiersRescued >= 5)
        {
            YouWin();
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(resetKey))
        {
            ResetScene();
        }
    }

    void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
