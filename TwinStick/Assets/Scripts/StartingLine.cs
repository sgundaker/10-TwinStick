using UnityEngine;
using System.Collections;

public class StartingLine : MonoBehaviour {

    public float startTime;
    private float elapsedTime;

    void Awake()
    {
        startTime = Time.time;
    }

    //Use this for initialization

    void Start () {

    }

    //Update is called once per frame
    void Update()
    {
        if (startTime > 0)
        {
            elapsedTime = Time.time - startTime;
        }
    }

   

    void OnGui()
    {
        GUI.Label(new Rect(300, 100, 100, 20), (elapsedTime.ToString()));
    }


}
