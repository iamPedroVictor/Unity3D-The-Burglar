using UnityEngine;
using System.Collections;

public class NextLevelLoad : MonoBehaviour {

    public string proximo;

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            Application.LoadLevel(proximo);
        }
    }


}
