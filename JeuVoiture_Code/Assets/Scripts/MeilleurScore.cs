using UnityEngine;
using UnityEngine.UI;

public class MeilleurScore : MonoBehaviour
{
    public Text MeilleurScoreTxt;
    public GameObject Timer;
    
    public float distanceParcourue;
    private float Meilleur_score = 0;
   void Update()
    {
        distanceParcourue = Timer.GetComponent<Timer>().distance;
        if(distanceParcourue >= StatsManager.instance.distance){
            Meilleur_score = distanceParcourue;
            MeilleurScoreTxt.text = Meilleur_score.ToString();
            StatsManager.instance.distance = Meilleur_score;
        }

         MeilleurScoreTxt.text = StatsManager.instance.distance.ToString();
         
    }
}
