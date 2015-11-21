using UnityEngine;
using System.Collections;

public class EnableGravity : MonoBehaviour {

    public GameObject target;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            target.GetComponent<Rigidbody2D>().gravityScale = 4;
        }
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
