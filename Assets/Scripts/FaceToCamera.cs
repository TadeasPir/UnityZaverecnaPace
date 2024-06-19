using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FaceToCamera : MonoBehaviour
{
    public Transform camera;
    public GameObject canvs;

    void LateUpdate()
    {
        canvs.transform.LookAt(canvs.transform.position + camera.forward);
    }
    
}
