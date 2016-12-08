using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

    public Object splash;
    public Object main;
    public Object levelmap;
    public Object game;
    [SerializeField]
    private string fase_aberta;

    void Start()
    {
        fase_aberta = Application.loadedLevelName.ToString();
        Debug.Log(fase_aberta);
        casoSplash();
    }

    void Update()
    {
        //CasoUserEscape();
    }

    void CasoUserEscape() {
        if (fase_aberta == splash.name)
        {
            if (Input.GetKey(KeyCode.Escape)) Application.Quit();
            //if (Input.anyKey) Application.LoadLevel(main.name);
        }
        else if (fase_aberta == main.name)
        {
            if (Input.GetKey(KeyCode.Escape)) Application.Quit();
        }
        else
        {
            if (Input.GetKey(KeyCode.Escape)) carregarMain();

        }
    }
    public void UsarEmHUD(string nome_da_cena)
    {
        Application.LoadLevel(nome_da_cena);
    }

    void carregarMain() {
        Application.LoadLevel("GameMenu");
    }

    void casoSplash() {
        if (fase_aberta == "Splash") Invoke("carregarMain", 4f);
    }

    public void casoReload() {
        Application.LoadLevel(fase_aberta);
    }
}
