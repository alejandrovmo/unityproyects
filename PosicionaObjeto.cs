using UnityEngine;

public class PosicionaObjeto : MonoBehaviour
{
    Vector3 m_NewPosition;
    // his is the new X position. Set it in the Inspector.
    public float m_XPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        //m_NewPosition = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Press the space key to change the x component of the vector
        //if (Input.GetKeyDown(KeyCode.Space))
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            m_NewPosition.x = m_XPosition;
        }
        // Change the position depending on the vector
        transform.position = m_NewPosition;
        
    }
}
