using UnityEngine;
using System.Collections;

public class PersistantData : MonoBehaviour {

    public GameObject music;
    private float musicTime;
    public GameObject player;
    private float Pgravity;
    public int currentLevel = 0;
    public bool restartFlag;
    // Use this for initialization
    void Awake (){
        DontDestroyOnLoad(transform.gameObject);
    }
    void OnLevelWasLoaded(int level)
    {
        if (level <= 4)
        {
            player = GameObject.Find("Player");
            music = GameObject.Find("EarthTheme");
            Debug.Log(music);
            music.GetComponent<AudioSource>().time = musicTime;
            music.GetComponent<AudioSource>().Play();
            GameObject.Find("Door").GetComponent<AudioSource>().Play();
            if (restartFlag == false)
                player.GetComponent<Rigidbody2D>().gravityScale = Pgravity;
        }
    }

    public int getLevel()
    {
        return currentLevel;
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        musicTime = music.GetComponent<AudioSource>().time;
        Pgravity = player.GetComponent<Rigidbody2D>().gravityScale;
    }
}
