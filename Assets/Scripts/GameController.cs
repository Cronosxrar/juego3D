using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static short puntos;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void awake(){
        DontDestroyOnLoad(gameObject);
    }

}
