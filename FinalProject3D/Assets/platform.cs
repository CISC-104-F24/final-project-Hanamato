using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float speed = 5f;
    public float height = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerstay (Collider collision)
    {
        if(collision.gameObject.name =="rising platform")
        {
            //transform.position = transform.position.y += speed * Time.deltaTime;
            
            Vector3 pos = transform.position;
            transform.position = transform.position + new Vector3 (0,2,0) * speed * Time.deltaTime;
            //transform.position = new Vector3(pos.x, newY, pos.z) * height; 
        }
    }

    private void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.name =="teleport")
        {
            transform.position = new Vector3(78.79f,25.66f,14f);
        } 
    }
    

}
