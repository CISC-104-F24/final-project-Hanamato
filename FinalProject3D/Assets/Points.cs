using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
public int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (points = 15)
        {
            Debug.Log("Obtained the highest score!");
        }
    }

    private void OnCollisionEnter (Collision collision)   
    {
        if (collision.gameObject.name =="redshroom") 
        {
            Debug.Log("Got a point!");
            points += 1; 
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.name =="blueshroom")
        {
            Debug.Log("Lost a point...");
            points -=1;
            Destroy(collision.gameObject);
        }

    }
}
