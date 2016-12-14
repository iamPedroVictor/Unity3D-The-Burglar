using UnityEngine;
using System.Collections;

public class ObjectsList : MonoBehaviour {

    public GameObject[] objectsTargets;

    // Use this for initialization
    void Start () {
        RandomObject();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void RandomObject(){
        if (objectsTargets.Length == 0)
            return;
        GameObject target = objectsTargets[Random.Range(0, objectsTargets.Length)];
        target.AddComponent<TargetObject>();
        Debug.Log("O objeto escolhido foi: " + target.name);
    }



}
