using UnityEngine;
using System.Collections;

public class PersistantData : MonoBehaviour {

    public GameObject music;
    private float musicTime = 0;
    public GameObject player;
    private float Pgravity = 3;
    public int currentLevel;
    public bool restartFlag;
    // Use this for initialization
    void Awake (){
        DontDestroyOnLoad(transform.gameObject);
    }
    void OnLevelWasLoaded(int level)
    {
        if (level <= 6)
        {
            player = GameObject.Find("Player");
            music = GameObject.Find("EarthTheme");
            music.GetComponent<AudioSource>().time = musicTime;
            music.GetComponent<AudioSource>().Play();
            GameObject.Find("Door").GetComponent<AudioSource>().Play();
            if(level == 3)
            {
                player.GetComponent<Rigidbody2D>().gravityScale = 3;
            }
            if (restartFlag == false)
            {
                player.GetComponent<Rigidbody2D>().gravityScale = Pgravity;
            }
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
        Debug.Log(currentLevel);
        if(Input.GetButton("Restart"))
        {
            restartFlag = true;
            Application.LoadLevel(Application.loadedLevelName);
        }
    }
}
