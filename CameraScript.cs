using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Transform player;
    public float smoothSpeed = 100f;

    public Vector3 offset;
    public Vector3 SmoothPosition;
    

    private void Start()
    {
        



           // offset = Vector3.Lerp(1.4f,1.94f,-6.74f);
    }


     void FixedUpdate()
    {
            
        offset = new Vector3(1.4f, 1.94f, -6.74f);
        Vector3 AdjustedPosition = offset + player.position;
        SmoothPosition = Vector3.Lerp(transform.position, AdjustedPosition, smoothSpeed * Time.deltaTime);
        transform.position = SmoothPosition;

       
    }


}
