using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform objSeguir;
    [SerializeField] private float velCamara = 120;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, objSeguir.position, velCamara * Time.deltaTime);
    }
}
