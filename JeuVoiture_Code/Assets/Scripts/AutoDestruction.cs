using UnityEngine;

public class AutoDestruction : MonoBehaviour
{
    public GameObject voiture;
    private float zelement;
    private float zmaxvoiture;
    
    void Start()
    {
        zelement = transform.position.z + GetComponent<Renderer>().bounds.size.z;
    }

    
    void Update()
    {
        if ( voiture == null) 
            Debug.Log("==> " + gameObject.name );
        else 
        {
            zmaxvoiture = voiture.transform.position.z - voiture.GetComponent<Renderer>().bounds.size.z;
            
            if(zelement < zmaxvoiture)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
