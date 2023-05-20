using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject player ;
    private Vector3 offset = new Vector3(0 , 3.7f , -7.98f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset ;
        //fpp change
        if (Input.GetKey("left shift"))
            transform.position = player.transform.position + new Vector3(0 , 2.1f , 0.9f );
    }
}
