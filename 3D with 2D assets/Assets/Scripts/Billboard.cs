using UnityEngine;

public class Billboard : MonoBehaviour
{
    void Update () {
        // Forces the object to face the camera
        transform.LookAt (Camera.main.transform.position, Vector3.up);
    }
}