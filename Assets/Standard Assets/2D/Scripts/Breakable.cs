using UnityEngine;
using System.Collections;

public class Breakable : MonoBehaviour {

    public float GravReq;

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log(coll.gameObject.tag);
        if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Boulder")
        {
            Debug.Log("Breakable Object: " + coll.gameObject.GetComponent<Rigidbody2D>().gravityScale);
            if (GravReq <= coll.gameObject.GetComponent<Rigidbody2D>().gravityScale)
            {
                Destroy(this.gameObject);
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
