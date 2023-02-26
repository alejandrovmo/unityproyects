using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTriangulo : MonoBehaviour
{
    public int Velocity;
    private Vector3 movimiento;
    private bool CambiarMov;
    private int Tiempo;
    Vector3 m_NewPosition;
    float  posicionX;
    float posicionX2;
    // Start is called before the first frame update
    void Start()
    {
        CambiarMov = true;
        //m_NewPosition = new Vector3(0.0f, 0.0f, 0.0f);
        movimiento = new Vector3(0.0f, 0.0f, 0.0f);
        Velocity = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += movimiento
        if(CambiarMov){
            transform.Translate((Time.deltaTime*Velocity),0,0);
            posicionX = transform.position.x;
            Debug.Log(posicionX);
        }
        
        if(posicionX < -9){
            CambiarMov = false;
            transform.Translate((-Time.deltaTime*Velocity),0,0);
            posicionX2 = transform.position.x;
        }

        if(posicionX2 > 1){
            Debug.Log(posicionX2);
            CambiarMov = true;
        }
    }
}
