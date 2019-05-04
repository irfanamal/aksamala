using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextButtonHandler : MonoBehaviour
{
    public Button nextButton;
    // Start is called before the first frame update
    void Start()
    {
        nextButton.onClick.AddListener(Next);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Next()
    {
        SceneManager.LoadScene(0);
    }
}
