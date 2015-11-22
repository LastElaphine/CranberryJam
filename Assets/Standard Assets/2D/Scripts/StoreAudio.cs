using UnityEngine;
using System.Collections;

public class StoreAudio : MonoBehaviour {

    private AudioSource music;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        music = GetComponent<AudioSource>();
        float musicTime = music.time;
	}
}
