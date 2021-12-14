using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorines : MonoBehaviour
{
    public Color color;
   
    
    // Start is called before the first frame update
    void Start()
    {
        //Modifica el color en el inicio
        GetComponent<MeshRenderer>().material.color = color;
    }

  
}
