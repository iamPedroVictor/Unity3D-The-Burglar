using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {

    public GameObject PauseMenu;

    void AtivarPause()
    {
        if (Time.timeScale == 0) {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        if (Time.timeScale == 1) {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void VoltarMenu() {
        BroadcastMessage("CarregarSplash");
    }
}
