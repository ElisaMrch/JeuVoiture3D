using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    private float acceleration = 10.0f;
    public Rigidbody rb;
    public float VitesseMax = 40 ;
    public float AugmentationVitesse = 5;


   

    
    void Start()
    {
         rb = GetComponent<Rigidbody>();
         InvokeRepeating("AugmentationVitesseMax", 5, 10);
         
    }

   
    void Update(){ 
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        


        if(Input.GetKeyDown("up")){
            speed += acceleration;
            if(speed>VitesseMax)
                speed = VitesseMax;
        }

        Debug.Log("vitessemax "+ VitesseMax);
                
            
        if (Input.GetKeyDown("down")){
                speed -= acceleration;
                if(speed < 0) 
                    speed = 0;

        }
        
        
        

        
    }

    void FixedUpdate(){
    
        if(IsWheelsOnGround()){
            rb.velocity = rb.transform.forward * speed;
            rb.angularVelocity = new Vector3(0,horizontalInput,0);
        }
        
    }

    void AugmentationVitesseMax(){
        VitesseMax+=AugmentationVitesse;
    }

     void OnTriggerEnter(Collider col){
      if(col.gameObject.tag == "Portail1"){
          SceneManager.LoadScene(1);
      }
       if(col.gameObject.tag == "Portail2"){
          SceneManager.LoadScene(3);
      }
  }

    private bool IsWheelsOnGround() 
    {
        bool i = true;
        foreach (Transform child in transform)
        {
            if (child.name == "EGO_nepasvoler")
            {
                pasvoler non = child.gameObject.GetComponent<pasvoler>();
                
                if (!non.IsCollided)
                {
                    i = false;
                    
                }
            }
        }
        return i;
    }
}