using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCameraFollow : MonoBehaviour
{
    public Transform targetObject;

    public Vector3 cameraOffset;
    public float smoothFactor = 0.5f;
    public bool lookAtTarget = false;

    // Start is called before the first frame update
    void Start()
    {
        //Finds objekt with player tag
        targetObject = GameObject.FindWithTag("Player").transform;
        cameraOffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Finds objekt with player tag
        targetObject = GameObject.FindWithTag("Player").transform;
    }

    void LateUpdate()
    {
        //Follows objekt
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);

        if (lookAtTarget)
        {
            transform.LookAt(targetObject);
        }
    }

 
}
