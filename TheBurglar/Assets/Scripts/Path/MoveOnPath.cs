using UnityEngine;
using System.Collections;

public class MoveOnPath : MonoBehaviour {

    public PathScript pathFollow;

    public int currentWaypointID = 0;
    public float speed;
    public float reachDistance = 1.0f;
    public float rotationSpeed = 5.0f;
    public string pathName;

    Vector3 last_position;
    Vector3 current_position;

	// Use this for initialization
	void Start () {
       // pathFollow = GameObject.Find(pathName).GetComponent<PathScript>();
        last_position = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(pathFollow.pathObjs[currentWaypointID].position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, pathFollow.pathObjs[currentWaypointID].position, Time.deltaTime * speed);

        var rotation = Quaternion.LookRotation(pathFollow.pathObjs[currentWaypointID].position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);

        if(distance <= reachDistance){
            currentWaypointID++;

        }

        if(currentWaypointID >= pathFollow.pathObjs.Count && pathFollow.isLoop){
            currentWaypointID = 0;
        }
	
	}
}
