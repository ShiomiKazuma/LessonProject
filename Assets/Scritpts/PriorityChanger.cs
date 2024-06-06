using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PriorityChanger : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera[] _vcameras;
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space))
        {
            if (_vcameras[0].Priority < _vcameras[1].Priority)
            {
                _vcameras[0].Priority = 1;
                _vcameras[1].Priority = 0;
            }
            else
            {
                _vcameras[0].Priority = 0;
                _vcameras[1].Priority = 1;
            }
        }
    }
}