using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {

    public GameObject PauseMenu, InGameMenu, GameOver;
    public GameObject visaoLuz;

    public static PauseManager instance = null;

    public void Awake()
    {
        if (instance != null)
            Destroy(this);
        else
            instance = this;
    }

    public void AtivarPause()
    {
        PauseMenu.SetActive(true);
        InGameMenu.SetActive(false);
        Time.timeScale = 0;
    }

    public void DesativarPause() {
        PauseMenu.SetActive(false);
        InGameMenu.SetActive(true);
        Time.timeScale = 1;
    }

    public void AtivarGameOver() {
        PauseMenu.SetActive(false);
        InGameMenu.SetActive(false);
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void Luz() {
        if (Time.timeScale != 0.3f)
        {
            visaoLuz.SetActive(true);
            Time.timeScale = 0.3f;
        }
        else {
            visaoLuz.SetActive(false);
            Time.timeScale = 1f;
        }
    }

}
