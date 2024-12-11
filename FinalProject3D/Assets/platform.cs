using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    //float speed = 5f;
    float height = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionstay (Collision collision)
    {
        if(collision.gameObject.name =="rising platform")
        {
            //transform.position = transform.position.y += speed * Time.deltaTime;
            
            Vector3 pos = transform.position;
            transform.position = transform.position + new Vector3 (0,2,0) * height *Time.deltaTime;
            //transform.position = new Vector3(pos.x, newY, pos.z) * height; 
        }
    }

}
