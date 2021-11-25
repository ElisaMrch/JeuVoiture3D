using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; //player = voiture
    public Vector3 offset = new Vector3(0, 5, -7);
    
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    //SMOOTH DAMP CAMERA

    /*public Transform target;
    public float smoothTime = 0.1F;
    private Vector3 velocity = Vector3.zero;
    
    
    void FixedUpdate()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -1));
        // Smoothly move the camera towards that target position
         transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

       
    }*/
}
