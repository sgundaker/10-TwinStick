using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;

    void Awake()
    {
        Debug.Log("Music Player Awake " + GetInstanceID());
        if (instance != null)
        {
            Destroy(gameObject);
            print("Duplicate music player self-destructing!");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    public AudioClip startClip;
    public AudioClip game1Clip;
    public AudioClip game2Clip;
    public AudioClip endClip;

    private AudioSource music;

	// Use this for initialization
	void Start () {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            print("Duplicate music player self destructing");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
            music = GetComponent<AudioSource>();
        }
	
	}

    void OnLevelWasLoaded(int level)
    {
        Debug.Log("MusicPlayer loaded level " + level);
        music.Stop();
        //if (level == 0)
        //{
        //    music.clip = startClip;
        //}
        if (level == 1)
        {
            music.clip = game1Clip;
        }
        if (level == 3)
        {
            music.clip = game2Clip;
        }
        if (level == 4)
        {
            music.clip = endClip;
        }
        music.loop = true;
        music.Play();
   }
	
	// Update is called once per frame
	void Update () {
	
	}
}
