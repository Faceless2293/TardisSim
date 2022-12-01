using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transporter : MonoBehaviour
{
    public Transform player;
    public Transform destination;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            player.transform.position = new Vector3 (destination.position.x, destination.position.y, destination.position.z);
            Debug.Log("Transported");
        }
    }
    
}
