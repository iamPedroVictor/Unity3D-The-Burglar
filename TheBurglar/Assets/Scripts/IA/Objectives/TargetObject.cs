using UnityEngine;
using System.Collections;

public class TargetObject : MonoBehaviour {

    [SerializeField]
    public readonly string tagRef = "Player";

    public bool isGet = false;

    public void GetTarget(){
            isGet = true;
    }

    private void OnTriggerEnter(Collider other){

        if (other.CompareTag(tagRef)){
            GetTarget();
        }
    }

}
