using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlanewithMouse : MonoBehaviour
{
    //public Rigidbody rigidbody;
    public Camera Camera;
    public GameObject Plane;
    public float speed = 1.0f;

    void Update()
    {
        /* rigidbody.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z)); */
        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed); 
        
    }
}
