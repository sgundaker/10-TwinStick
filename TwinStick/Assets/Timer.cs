using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text myText;
    public static float Counter;

    // Use this for initialization
    void Start()
    {
        myText = GetComponent<Text>();
        PlayerPrefs.SetFloat("SessionTime", Time.realtimeSinceStartup);
        
    }

	// Update is called once per frame
	void Update() {
        float Counter = Time.timeSinceLevelLoad;

        string minSec = string.Format("{0}:{1:00}", (int)Counter % 60, (Counter - (int)Counter % 60) * 100);
        myText.text = minSec;
    }

    //public void Counter (float time)
    //{
    //    float counter = Time.timeSinceLevelLoad;
    //    string minSec = string.Format("{0}:{1:00}", (int)counter % 60, (counter - (int)counter % 60) * 100);
    //    myText.text = minSec;
    //}
   

}
