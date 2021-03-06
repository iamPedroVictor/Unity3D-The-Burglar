﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(FieldofView))]
public class FieldofViewEditor : Editor {

    void OnSceneGUI(){
        FieldofView fow = (FieldofView)target;
        Handles.color = Color.blue;
        Handles.DrawWireArc(fow.transform.position, Vector3.up, Vector3.forward, 360, fow.viewRadius);

        Vector3 viewAngleA = fow.DirFromAngle(-fow.viewAngle / 2, false);
        Vector3 viewAngleB = fow.DirFromAngle(fow.viewAngle / 2, false);

        Handles.color = Color.yellow;
        Handles.DrawLine(fow.transform.position, fow.transform.position + viewAngleA * fow.viewRadius);
        Handles.DrawLine(fow.transform.position, fow.transform.position + viewAngleB * fow.viewRadius);

        Handles.color = Color.red;
        foreach(Transform visibleTarget in fow.visibleTargets){
            Handles.DrawLine(fow.transform.position, visibleTarget.position);
        }
        
    }

}
