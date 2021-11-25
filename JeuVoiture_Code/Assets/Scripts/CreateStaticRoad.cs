using UnityEngine;

public class CreateStaticRoad : MonoBehaviour
{
    
    public GameObject plane;
    public GameObject obstacle;
    public GameObject[] lst_obstacles;
    public GameObject[] lst_routes;
    public GameObject voiture;
    public GameObject EGO_parent_route;
    public GameObject EGO_parent_obstacle;
    private GameObject PremierMorceauRoute;
    public Transform PosRoute;
    private float zRouteMax;
    private float zObstacle;
    private float zVoitureMax;
    private float xPosCloneObstacle1;
    private float xPosCloneObstacle2;
    private float zPosCloneObstacle;
    private int numObstacle;
    private int numRoute;
    private int NombreSpawn = 0;
    public int NombreSpawnMax = 1;
    public int Augmentation = 1;
    private int nbpave = 0;
    private float Largeur_Route_Min;
    private float Largeur_Route_Max;

    void Awake()
    {
        //initialise la route
        zRouteMax = PosRoute.position.z + plane.GetComponent<Renderer>().bounds.size.x;
        voiture.transform.position= new Vector3(0,1,0);
        
        PremierMorceauRoute = GameObject.Instantiate(plane, PosRoute.position, Quaternion.Euler(0,90,0), EGO_parent_route.transform);
        PremierMorceauRoute.GetComponent<AutoDestruction>().voiture=voiture;
    }

 
    void Start()
    {
        //initialise les obstacles
         zObstacle = obstacle.transform.position.z + obstacle.GetComponent<Renderer>().bounds.size.z;
         Largeur_Route_Min = plane.transform.position.x - plane.GetComponent<Renderer>().bounds.size.x;
         Largeur_Route_Max = plane.transform.position.x + plane.GetComponent<Renderer>().bounds.size.x;
         InvokeRepeating("AugmentationNbSpawn", 5,10);
    }

    void Update()
    {
        zVoitureMax =  voiture.transform.position.z + voiture.GetComponent<Collider>().bounds.size.z;

        GameObject cloneRoute;
        
       
        if((zRouteMax - zVoitureMax) < 20){

            numRoute = Random.Range(0, lst_routes.Length);
            cloneRoute = GameObject.Instantiate(lst_routes[numRoute], new Vector3(0,0,zRouteMax), Quaternion.Euler(0,90,0), EGO_parent_route.transform);
            zRouteMax = cloneRoute.transform.position.z + cloneRoute.GetComponent<Renderer>().bounds.size.z;

            cloneRoute.GetComponent<AutoDestruction>().voiture=voiture;
           
            
            nbpave=nbpave+1;

            if(nbpave % 5 == 0){ 
                SapwnObstacle();
            }
       }
        zVoitureMax =  voiture.transform.position.z - voiture.GetComponent<Collider>().bounds.size.z;

    }

     void AugmentationNbSpawn(){
        NombreSpawnMax+=Augmentation;
    }
    
    void SapwnObstacle(){
        GameObject cloneObstacle1;
        GameObject cloneObstacle2;

        NombreSpawn = Random.Range(0, NombreSpawnMax);
                

        while( NombreSpawn <= NombreSpawnMax){

            numObstacle = Random.Range(0, lst_obstacles.Length);

            xPosCloneObstacle1 = Random.Range(Largeur_Route_Min, Largeur_Route_Max);
            zPosCloneObstacle = Random.Range(voiture.transform.position.z + voiture.GetComponent<Renderer>().bounds.size.z + 4, zRouteMax);

            cloneObstacle1= GameObject.Instantiate(lst_obstacles[numObstacle], new Vector3(xPosCloneObstacle1,0,zPosCloneObstacle), Quaternion.Euler(0,180,0), EGO_parent_obstacle.transform);
            cloneObstacle1.name=nbpave+"_1";
            zObstacle = cloneObstacle1.transform.position.z + cloneObstacle1.GetComponent<Renderer>().bounds.size.z;
            cloneObstacle1.GetComponent<AutoDestruction>().voiture=voiture;

            numObstacle = Random.Range(0, lst_obstacles.Length);

            zPosCloneObstacle = Random.Range(voiture.transform.position.z + voiture.GetComponent<Renderer>().bounds.size.z + 4, zRouteMax);
            xPosCloneObstacle2 = Random.Range(Largeur_Route_Min, Largeur_Route_Max);

            numObstacle = Random.Range(0, 1);

            cloneObstacle2= GameObject.Instantiate(lst_obstacles[numObstacle], new Vector3(xPosCloneObstacle2,0,zPosCloneObstacle), Quaternion.Euler(0,180,0), EGO_parent_obstacle.transform);
            zObstacle = cloneObstacle2.transform.position.z + cloneObstacle2.GetComponent<Renderer>().bounds.size.z;
            cloneObstacle2.name=nbpave+"_3";
            cloneObstacle2.GetComponent<AutoDestruction>().voiture=voiture;

            NombreSpawn++;
                
        }
    }


}
