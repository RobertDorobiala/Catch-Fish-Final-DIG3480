using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoDoFishController : MonoBehaviour
{

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("FishCheck"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Bowl"))
        {
            Destroy(gameObject);
            //GameLoader.AddScore(1);
        }
    }
}
