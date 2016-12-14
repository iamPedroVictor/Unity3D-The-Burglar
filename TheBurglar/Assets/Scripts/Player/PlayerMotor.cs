using UnityEngine;
using System.Collections;


public class PlayerMotor : MonoBehaviour {

    private Vector3 velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;

    private Transform tf;
    private Rigidbody rb;

    private void Start(){
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
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
        //rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
    }

    private void FixedUpdate(){
        PerformMovement();
        PerformRotation();
    }

}
