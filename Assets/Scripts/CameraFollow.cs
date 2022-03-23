using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetObject;


    public Vector3 cameraOffSet;

    public float smoothFactor = 0.5f;

    public bool lookAtTarget = false;
    // Start is called before the first frame update
    void Start()
    {
        cameraOffSet = transform.position - targetObject.transform.position;    
    }

    void LateUpdate() {
         Vector3 newPosition = targetObject.transform.position + cameraOffSet;
         transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);   

         if (lookAtTarget){
             transform.LookAt(targetObject);
         }
    }
}
