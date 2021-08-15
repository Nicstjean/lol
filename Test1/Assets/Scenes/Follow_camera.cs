using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_camera : MonoBehaviour
{

    public GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        follow();
    }

    void follow() 
    {
        float diff = player.transform.position.y - transform.position.y;
        float tresh = 4f;

        if (Mathf.Abs(diff) >= tresh) {

            if (diff > 0) {
                transform.position = new Vector3(player.transform.position.x, transform.position.y + (diff - tresh), -15);
            }

            else
                transform.position = new Vector3(player.transform.position.x, transform.position.y + (diff + tresh), -15);
            
        }
        
        else
            transform.position = new Vector3(player.transform.position.x, transform.position.y, -15);


    }
}
