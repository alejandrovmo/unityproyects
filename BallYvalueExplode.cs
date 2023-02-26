using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallYvalueExplode : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    GameObject plane;
    public ParticleSystem plasmaExplode;
    float verticalBallValue;
    float planeverticalY;
    //float ballValuePositionYtoExplode = -5;
    bool isParticlePlaying = false;

    void Start()
    {
        
        
        //plasmaExplode = GameObject.Find("PlasmaExplosionEffect").GetComponent<ParticleSystem>();
        plane = GameObject.Find("Plane");
        planeverticalY = plane.transform.position.y;
        plasmaExplode.Play(isParticlePlaying);
        //Debug.Log(planeverticalY);
        //Debug.Log(plasmaExplode);

    }

    // Update is called once per frame
    void Update()
    {

        verticalBallValue = ball.transform.position.y;
        //Debug.Log(verticalBallValue);
        
        
        if(planeverticalY > verticalBallValue && !isParticlePlaying){
         //   Debug.Log(planeverticalY);
            CheckPositionyExplode();
            //plasmaExplode.SetActive(true);
            
            //Destroy(ball);
            
        }
        
        plasmaExplode.Stop();

    }
    void CheckPositionyExplode(){
      //  Debug.Log("Play");
        isParticlePlaying=true;
        plasmaExplode.Play(isParticlePlaying);

        if(-8 == verticalBallValue){
            Destroy(ball);
        }
    }
}