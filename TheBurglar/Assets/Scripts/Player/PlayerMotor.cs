using UnityEngine;
using System.Collections;


public class PlayerMotor : MonoBehaviour {

    private Vector3 velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;

    private Transform tf;

    private void Start(){
        tf = GetComponent<Transform>();
    }

    // Gets a movement vector
    public void Move(Vector3 _velocity){
        velocity = _velocity;
    }

    // Gets a rotational vector
    public void Rotate(Vector3 _rotation){
        rotation = _rotation;
    }

    void PerformMovement(){
        if(velocity != Vector3.zero){
            tf.Translate(velocity);
        }
    }

    void PerformRotation(){
        tf.Rotate(rotation);
    }

    private void Update(){
        PerformMovement();
        PerformRotation();
    }

}
