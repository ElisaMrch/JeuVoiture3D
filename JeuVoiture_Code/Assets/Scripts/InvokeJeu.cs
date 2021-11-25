using UnityEngine;
using UnityEngine.SceneManagement;


public class InvokeJeu : MonoBehaviour
{
    void Start()
    {
        Invoke("retour", 3);
        
    }

    public void retour()
    {
         SceneManager.LoadScene(0);
    }
}
