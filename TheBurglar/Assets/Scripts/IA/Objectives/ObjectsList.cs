using UnityEngine;
using System.Collections;

public class ObjectsList : MonoBehaviour {

    public GameObject[] objectsTargets;
    private TargetObject target;
    public bool canExit = false;

    // Use this for initialization
    void Start () {
        RandomObject();

    }
	
	// Update is called once per frame
	void Update () {
        if (CheckQuest()){
            //Faça alguma coisa
        }
	}

    private void RandomObject(){
        if (objectsTargets.Length == 0)
            return;
        GameObject _target = objectsTargets[Random.Range(0, objectsTargets.Length)];
        _target.AddComponent<TargetObject>();
        Debug.Log("O objeto escolhido foi: " + _target.name);
        target = _target.GetComponent<TargetObject>();
        target.listRef = this;
    }

    private bool CheckQuest(){
        if (target.isGet){
            return true;
        }
        return false;
    }



}
