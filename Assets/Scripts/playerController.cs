using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject player;
    public float playerSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            player.transform.Translate(0, 0, playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(0, 0, -playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
        }

    }
    
}
