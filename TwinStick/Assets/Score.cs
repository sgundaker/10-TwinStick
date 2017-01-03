using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        Text myText = GetComponent<Text>();
        float sessionTime = Time.realtimeSinceStartup - PlayerPrefs.GetFloat("SessionTime");
        myText.text = sessionTime.ToString();

        Debug.Log("Time was " + sessionTime);
       
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
