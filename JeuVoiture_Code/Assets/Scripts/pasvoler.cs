using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasvoler : MonoBehaviour
{
    private bool isCollided;

    public bool IsCollided
    {
        get { return isCollided; }
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Touche la route");
        if (other.gameObject.tag == "Road")
        {
            isCollided = true;
            Debug.Log("Wheel Touching the ground");
        }
    }

    void OnTriggerExit(Collider other)
    {
        isCollided = false;
        Debug.Log("Collision reset");
    }
}
