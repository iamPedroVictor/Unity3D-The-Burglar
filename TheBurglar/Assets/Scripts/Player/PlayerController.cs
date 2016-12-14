using UnityEngine;
using System.Collections;
[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float movimentSpeed = 5f;
    [SerializeField]
    private float rotateSpeed = 30f;

    private const string fire = "Fire1";

    // Component caching
    private PlayerMotor motor;

    public bool isFire;

    // Use this for initialization
    void Start () {
        motor = GetComponent<PlayerMotor>();
	
	}
	
	// Update is called once per frame
	void Update () {

        float _xMov = Input.GetAxis("Horizontal");
        float _zMov = Input.GetAxis("Vertical");

        float _Moviment = (_zMov * movimentSpeed) * Time.deltaTime;
        float _Rotation = rotateSpeed * _xMov * Time.deltaTime;
        Vector3 _Rotate = new Vector3(0, _Rotation, 0);
        Vector3 _velocity = new Vector3(0, 0, _Moviment);

        //Apply movement
        motor.Move(_velocity);
        motor.Rotate(_Rotate);

        if (Input.GetButtonDown(fire)){
            isFire = true;
            Invoke("FireOff", 1);
        }

    }

    private void FireOff(){
        isFire = false;
    }
    
}
