using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangementCamera : MonoBehaviour
{
    public GameObject camera1personne;
    public GameObject camera3personne;

    private bool IsChanger = true;
    void Start()
    {
        camera1personne.SetActive(false);
        camera3personne.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown("c")){
            if(IsChanger == true){
                camera1personne.SetActive(true);
                camera3personne.SetActive(false);
                IsChanger = false;
            }
            else{
                camera1personne.SetActive(false);
                camera3personne.SetActive(true);
                IsChanger = true;
            }
        }
    }
}
