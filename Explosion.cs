using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    ParticleSystem particle;
    //bool isTouching = false;
    //GameObject ball;
    GameObject plane;
    float planeverticalY;
    float verticalBallValue;
    public GameObject ball;
    GameObject checaColision;
    public GameObject temporalObject;
    int planeY;
    int ballY;

    float separacion;
    
    void Start()
    {
        ball = GameObject.Find("Sphere1");
        particle = GameObject.Find("PlasmaExplosionEffect").GetComponent<ParticleSystem>();
        particle.Stop();
        //Debug.Log("hola");
        //isTouching = false;
        plane = GameObject.Find("Plane");
        temporalObject = ball;
        //Debug.Log(temporalObject);

        

    }
    void Update(){
        if(particle != null){
            planeverticalY = plane.transform.position.y;
            planeY=(int)planeverticalY;
        
            verticalBallValue = ball.transform.position.y;
            ballY=(int)verticalBallValue;
          //  Debug.Log("Plano Y = "+planeY);
          //  Debug.Log("Ball Y = "+ballY);
            //isTouching = true;
            temporalObject = checaColision;
            if (planeY > ballY){ // && temporalObject == null){
                //checaEplosion();
                temporalObject = null;
            //    Debug.Log("1er if, Funcion Update, PlanoY = "+planeY+" BallY = "+ballY+" temporalObject = "+temporalObject);
                }
            else{
                temporalObject = ball;
            }
            
            if(temporalObject == null){
                //Debug.Log("funcion Update");
              //  Debug.Log("2do. if, Funcion Update, PlanoY = "+planeY+" BallY = "+ballY+" temporalObject = "+temporalObject);
                if(particle != null){
                    checaEplosion();
                }
                
                if(ballY < -5){
                    Destroy(particle);
                    Destroy(ball);
                }
                
            }
        }
        
    }
            // <summary>
            /// OnCollisionStay is called once per frame for every collider/rigidbody
            /// that is touching rigidbody/collider.
            // </summary>
            // <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionStay(Collision other)
    {
                particle.Stop();
                checaColision = other.gameObject;  
                temporalObject = checaColision;
    }
    void OnCollisionExit(Collision other) {
        
        /*if(planeverticalY > verticalBallValue){ */
        checaColision = other.gameObject;
        temporalObject = checaColision;
      //  Debug.Log("funcion OnCollisionExit");
        //isTouching = false;
    }
    public void checaEplosion(){
        
      //  Debug.Log("Funcion checaEsplosion"+"temporalObject = "+temporalObject);
        particle.Play();
        /*
        if (temporalObject == null){

            temporalObject = ball;
            particle.Stop();

        }*/
        
            

    }


}
