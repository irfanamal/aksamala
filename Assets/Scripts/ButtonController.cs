using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public Button startGame;
    public Button quitGame;
    // Start is called before the first frame update
    void Start()
    {
        startGame.onClick.AddListener(StartGame);
        quitGame.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
