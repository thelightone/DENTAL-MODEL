using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 100.0f;

    void Update()
    {
        if (Input.anyKey && !Input.GetMouseButton(1))
        {
            float rotationX = Input.GetAxis("Vertical") * rotationSpeed;
            float rotationY = Input.GetAxis("Horizontal") * rotationSpeed;

            rotationX *= Time.deltaTime;
            rotationY *= Time.deltaTime;

            transform.Rotate(-rotationX, 0, 0, Space.World);

            transform.Rotate(0, -rotationY, 0, Space.World);
        }
    }
}
