using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pushBoton : MonoBehaviour {
 
    public string URL;  
    public void linkFunc()
    {
        Application.OpenURL(URL);
        
    }
}