using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerScene : MonoBehaviour
{
    public GameObject route;
    public Transform PosRoute;
    public GameObject panneauScore;
    public GameObject voiture;
    private float Largeur_Route_Max;
    private float Largeur_Route_Min;
    

    void Start()
    {
        Largeur_Route_Max = PosRoute.transform.position.x + route.GetComponent<Renderer>().bounds.size.z/2;
        Largeur_Route_Min = PosRoute.transform.position.x - route.GetComponent<Renderer>().bounds.size.z/2;
    }

    
    void Update()
    {
        if (voiture.transform.position.x > Largeur_Route_Max || voiture.transform.position.x < Largeur_Route_Min)
        {
            SceneManager.LoadScene(2);
        }
    }

    void OnTriggerEnter(Collider col){
      if(col.gameObject.tag == "Portail1"){
          SceneManager.LoadScene(1);
      }
       if(col.gameObject.tag == "Portail2"){
          SceneManager.LoadScene(3);
      }
  }

    public void ReturnMenu(){
        panneauScore.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
