using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StatsManager : MonoBehaviour
{
    public static StatsManager instance;
    public float distance;
    public bool IsJeuChrono;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);       
        }
        else if (instance != this)
        {
            Destroy(gameObject);             
        }
      
    }    
}
