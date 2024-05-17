using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    [SerializeField] Transform followTarget;

    [SerializeField] float distance = 3;

    private void Update()
    {
        transform.position = followTarget.position - new Vector3(0, 0, distance);
    }
}
