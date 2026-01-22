using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    
    void Update()
    {
        
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

       
        worldPoint.z = 0;

        transform.position = Vector3.Lerp(transform.position, worldPoint, speed * Time.deltaTime);
    }
}
