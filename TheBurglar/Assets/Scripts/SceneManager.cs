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
        if (Application.loadedLevelName.ToString() == splash.name){
            if (Input.GetKey(KeyCode.Escape)) Application.Quit();
            //if (Input.GetTouch(0).phase == TouchPhase.Began) Application.LoadLevel(main.name);
            if (Input.anyKey) Application.LoadLevel(main.name);
        }
        else if (Application.loadedLevelName.ToString() == main.name){
            if (Input.GetKey(KeyCode.Escape)) Application.Quit();
        }
        else {
            if (Input.GetKey(KeyCode.Escape)) Application.LoadLevel(main.name);

        }
    }

    public void UsarEmHUD(string nome_da_cena)
    {
        Application.LoadLevel(nome_da_cena);
    }
}
