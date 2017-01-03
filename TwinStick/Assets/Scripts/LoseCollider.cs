using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class LoseCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Application.LoadLevel("YouDied");
        }
        
    }  
}
