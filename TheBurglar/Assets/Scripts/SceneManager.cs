using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

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

        if (fase_aberta == splash.name) casoSplash();

    }

    void Update()
    {
        CasoUserEscape();
    }

    void CasoUserEscape() {
        if (fase_aberta == splash.name)
        {
            if (Input.GetKey(KeyCode.Escape)) Application.Quit();
            //if (Input.GetTouch(0).phase == TouchPhase.Began) Application.LoadLevel(main.name);
            if (Input.anyKey) Application.LoadLevel(main.name);
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
        Application.LoadLevel(main.name);
    }

    void casoSplash() {
        Invoke("carregarMain", 4f);
    }

    public void casoReload() {
        Application.LoadLevel(fase_aberta);
    }
}
