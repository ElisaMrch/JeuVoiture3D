using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Maluce : MonoBehaviour
{

    public float diminutionVitesse = 2;

  void OnTriggerEnter(Collider col){
      if(col.gameObject.tag == "Obstacle"){
          gameObject.GetComponent<PlayerController>().VitesseMax-= diminutionVitesse;
          if(gameObject.GetComponent<PlayerController>().VitesseMax <= 1 ){
            gameObject.GetComponent<PlayerController>().VitesseMax = 1;
          } 
      }
  }
}
