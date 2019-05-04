using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text orbsLeftText;
    public Light player;
    private int orbsLeft;
    private bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        orbsLeftText.text = "";
        orbsLeft = 10;
        UpdateOrbs();
    }

    // Update is called once per frame
    void Update()
    {
        player.intensity = 0.1f + 0.2f * (10 - orbsLeft);
        if (gameOver)
        {
            SceneManager.LoadScene(3);
        }
        if (orbsLeft == 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void OrbsTaken()
    {
        orbsLeft--;
        UpdateOrbs();
    }

    void UpdateOrbs()
    {
        orbsLeftText.text = "" + orbsLeft;
    }

    public void GameOver()
    {
        gameOver = true;
    }
}
