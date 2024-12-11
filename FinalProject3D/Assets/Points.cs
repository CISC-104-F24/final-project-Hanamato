using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
public int points = 0;
public GameObject door;
public string LevelName;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (points == 10)
        {
            Debug.Log("Unlocked a new stage!");
            door.SetActive(true);

        }

        if (points == -2)
        {
            Debug.Log("Game Over");
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

        if(collision.gameObject.name =="locked")
        {
            SceneManager.LoadScene(LevelName);
        }

    }
}
