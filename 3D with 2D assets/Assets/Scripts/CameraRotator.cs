using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public float degreesPerSec;
    public Transform target;

    private void Start () {
        transform.LookAt (target);
    }

    void Update () {
        transform.RotateAround (target.position, Vector3.up, degreesPerSec * Time.deltaTime);
    }
}
