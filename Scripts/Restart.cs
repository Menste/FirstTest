using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject buttonRestart;
    public GameObject textLose;
    public GameObject textWin;
    public Win scriptWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0 && scriptWin.win == false)
        {
            buttonRestart.SetActive(true);
            textLose.SetActive(true);
            textWin.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (Time.timeScale == 0 && scriptWin.win == true)
        {
            buttonRestart.SetActive(true);
            textLose.SetActive(false);
            textWin.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        buttonRestart.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;

    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
       // Application.Quit();
    }
}
