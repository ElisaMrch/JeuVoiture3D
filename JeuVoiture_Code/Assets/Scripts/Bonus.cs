using UnityEngine;

public class Bonus : MonoBehaviour
{
    public float augmentionVitesse;

  void OnTriggerEnter(Collider col){
      
      if(col.gameObject.tag == "objBonnus"){
          gameObject.GetComponent<PlayerController>().VitesseMax+= augmentionVitesse;
      }
  }
}
