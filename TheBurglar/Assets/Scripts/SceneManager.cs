using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneManager : MonoBehaviour {

    public Object splash;
    public Object main;
    public Object levelmap;
    public Object game;

    void Start()
    {
        if (Application.loadedLevelName.ToString() == splash.name)
        {
            Debug.Log(splash.name.ToString());
            //Application.LoadLevelAsync(main.name);
        }
        
    }

    void Update()
    {
        // Debug.Log(Application.loadedLevel.ToString());
        if (Input.GetKey(KeyCode.Escape)) Application.Quit();

        if (Application.loadedLevelName.ToString() == splash.name)
        {            
            if (Input.GetKey(KeyCode.Mouse0)) Application.LoadLevel(main.name);
        }
    }

    // Os metodos abaixo sao chamados via broadcast

    void CarregarSplash() {
        Application.LoadLevel(splash.name);
    }
    void CarregarMain() {
        Application.LoadLevel(main.name);
    }
}
