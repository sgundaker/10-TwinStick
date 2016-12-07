using UnityEngine;
using System.Collections;

public class ReplaySystem : MonoBehaviour {

    private const int bufferFrames = 100;
    private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];
    private Rigidbody rigidBody;
	
	void Start () {
        //MyKeyFrame testKey = new MyKeyFrame(1.0f, Vector3.up, Quaternion.identity);
        rigidBody = GetComponent<Rigidbody>();	
	}
	
	
	void Update ()
    {
        Record();

    }

    void PlayBack()
    {
        rigidBody.isKinematic = true;
        int frame = Time.frameCount % bufferFrames;
        print("Reading frame " + frame);
        transform.position = keyFrames[frame].position;
        transform.rotation = keyFrames[frame].rotation;
    }

    private void Record()
    {
        rigidBody.isKinematic = false;
        int frame = Time.frameCount % bufferFrames;
        float time = Time.time;
        print("Writing frame" + frame);

        keyFrames[frame] = new MyKeyFrame(time, transform.position, transform.rotation);
    }
}

/// <summary>
/// Structure for storing time, rotation, and position
/// </summary>
public struct MyKeyFrame
{
    public float frameTime;
    public Vector3 position;
    public Quaternion rotation;

    public MyKeyFrame (float aTime, Vector3 aPosition, Quaternion aRotation)
    {
        frameTime = aTime;
        position = aPosition;
        rotation = aRotation;
    }
}
