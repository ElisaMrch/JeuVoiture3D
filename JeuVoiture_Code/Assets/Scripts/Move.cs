using UnityEngine;

public class Move : MonoBehaviour
{
    //private variable
    private float speed = 5.0f;
    private float Largeur_Route_Max;
    private float Largeur_Route_Min;
    private float Largeur_Obtacle_Max;
    private float Largeur_Obtacle_Min;
    public GameObject route;
    private bool IsDeplacementVersLaDroite;

    void Start()
    {
        //recup les positions de la route
        Largeur_Route_Max = route.transform.position.x + route.GetComponent<Collider>().bounds.size.x/2;
        Largeur_Route_Min = route.transform.position.x - route.GetComponent<Collider>().bounds.size.x/2;
        
        IsDeplacementVersLaDroite = true;
    }

    void Update()
    {
        //recup les positions de la route
        Largeur_Obtacle_Max = transform.position.x + GetComponent<Collider>().bounds.size.x/2;
        Largeur_Obtacle_Min = transform.position.x - GetComponent<Collider>().bounds.size.x/2;
        
        //mouvement
        if (IsDeplacementVersLaDroite) transform.Translate(Vector3.right * Time.deltaTime * speed);
        else transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (Largeur_Obtacle_Max >= Largeur_Route_Max) 
            {IsDeplacementVersLaDroite = false;}
        if (Largeur_Obtacle_Min <= Largeur_Route_Min) 
            {IsDeplacementVersLaDroite = true;}
        
    }

}
