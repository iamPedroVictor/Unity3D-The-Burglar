using UnityEngine;
using System.Collections;

public class TargetObject : MonoBehaviour {

    [SerializeField]
    public readonly string tagRef = "Player";
    public ObjectsList listRef;

    public bool isGet = false;

    public void GetTarget(){
        isGet = true;
        Debug.Log("Pegou o objeto");
        listRef.canExit = true;
        gameObject.SetActive(false);

    }

    private void OnTriggerEnter(Collider other){

        if (other.CompareTag(tagRef)){
            GetTarget();
        }
    }

}
