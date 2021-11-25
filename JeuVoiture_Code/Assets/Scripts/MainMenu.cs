using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject fenetreOption;

    public void StartPlayNormalMode(){
         SceneManager.LoadScene(1);
         StatsManager.instance.IsJeuChrono = false;
    }

    public void StartPlayChronoMode(){
         SceneManager.LoadScene(4);
         StatsManager.instance.IsJeuChrono = true;
    }

    public void Option(){
        fenetreOption.SetActive(true);
    }

    public void QuitGame(){
        Application.Quit();
    }

}
