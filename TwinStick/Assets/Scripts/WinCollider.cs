using UnityEngine;
using System.Collections;

public class WinCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Application.LoadLevel("Win");
        }
        Debug.Log("Trigger NextLevel");
    }
}
