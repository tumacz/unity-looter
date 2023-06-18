using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    private Camera _mainCam;
    [SerializeField] private Transform _target;
    private float camPosZ;

    void Start()
    {
        _mainCam = FindObjectOfType<Camera>();
        camPosZ = _mainCam.transform.position.z;
    }

    void Update()
    {
        _mainCam.transform.position = new Vector3(_target.position.x, _target.position.y, camPosZ);
    }
}
