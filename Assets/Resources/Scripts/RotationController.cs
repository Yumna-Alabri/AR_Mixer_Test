using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Android;

public class RotationController : MonoBehaviour
{
    public Vector3 rotationVector;

    private void Update()
        {
            transform.Rotate(rotationVector * Time.deltaTime);
        }

}
