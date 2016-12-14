using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PathScript : MonoBehaviour
{

    public Color rayColor = Color.white;
    public Color selectedColor = Color.blue;
    public List<Transform> pathObjs = new List<Transform>();
    Transform[] theArray;
    public float sphereSize = 0.5f;

    public bool isLoop;

    private void OnDrawGizmos(){

        Gizmos.color = rayColor;
        theArray = GetComponentsInChildren<Transform>();
        pathObjs.Clear();

        foreach(Transform path_Obj in theArray){
            if(path_Obj != this.transform){
                pathObjs.Add(path_Obj);
            }
        }
        
        for(int i = 0; i < pathObjs.Count; i++)
        {
            Vector3 position = pathObjs[i].position;
            if (i > 0)
            {
                Vector3 previous = pathObjs[i - 1].position;
                Gizmos.color = rayColor;
                Gizmos.DrawLine(previous, position);
                Gizmos.DrawWireSphere(position, sphereSize);
            }
            else {
                Vector3 previous = pathObjs[1].position;
                Gizmos.color = rayColor;
                Gizmos.DrawLine(previous, position);
                Gizmos.DrawWireSphere(position, sphereSize);
                if (isLoop)
                {
                    previous = pathObjs[pathObjs.Count - 1].position;
                    Gizmos.DrawLine(previous, position);
                }
            }

        }

    }

}