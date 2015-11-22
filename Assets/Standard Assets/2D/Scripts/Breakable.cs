using UnityEngine;
using System.Collections;

public class Breakable : MonoBehaviour {

    public float GravReq;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Boulder")
        {
            if (GravReq <= coll.gameObject.GetComponent<Rigidbody2D>().gravityScale)
            {
                this.GetComponent<AudioSource>().Play();
                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                Destroy(this.gameObject.GetComponent<SpriteRenderer>());
                Debug.Log("Breakable Object destoryed.");
            }
        }

    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
