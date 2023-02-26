using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    //Runs code when an object collides with the object
    //that this script is attached to
    //THIS IS FOR 2D COLLICIONS ONLY
    /*
    private void private void OnCollisionEnter2D(Collision2D other) {
        
        //Destroys object that collides with the object that this script is attached to
        Destroy(collidion.gameObject);
    }
    */
    //Runs code when an object collides with the object
    //that this script is attached to
    //THIS IS FOR 3D COLLICIONS ONLY
    public GameObject ball;

    private void OnCollisionEnter(Collision other) {
        //Destroy object that collides with the object
        //that this script is attached to
        Destroy(ball);

    }
}
