using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float moveForward = Input.GetAxis("Vertical") * _speed;
            float moveSide = Input.GetAxis("Horizontal") * _speed;

            moveForward *= Time.deltaTime;
            moveSide *= Time.deltaTime;

            transform.Translate(Vector3.forward* moveForward);

            transform.Translate(-Vector3.left * moveSide);
        }
    }
}
