using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    
    public GameObject panneauScore;
    public GameObject player;

    public Text distanceTxt;

    public float distance;
    
    private float time;

    void Start(){
            time = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = string.Format("{0:0}:{1:00}",Mathf.Floor(time/60),time%60);
        time += Time.deltaTime;

        if(StatsManager.instance.IsJeuChrono == true){
            if(time >= 60)
            {
                player.GetComponent<PlayerController>().enabled = false;
                panneauScore.SetActive(true);
                distanceTxt.text = player.transform.position.z.ToString();
                distance = player.transform.position.z;
            }
        }
    }

  

    
}
