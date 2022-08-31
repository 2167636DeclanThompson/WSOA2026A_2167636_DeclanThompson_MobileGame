using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{       
    private float cameraMove = 0.025f;
    void Update()
    {
        var cameraPosition = Camera.main.gameObject.transform.position;
        cameraPosition.x += cameraMove;
        Camera.main.gameObject.transform.position = cameraPosition;
    }
}
