using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour {

    [Header("Qual o alvo?")]
    public GameObject alvo;
    [Header("Qual a velocidade da perseguição")]
    public float velocidade;

	void FixedUpdate () {
        if (transform.position != alvo.transform.position)
            transform.position = Vector3.MoveTowards(transform.position, alvo.transform.position, velocidade * Time.deltaTime);
    }
}
