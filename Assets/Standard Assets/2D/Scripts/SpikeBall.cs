using UnityEngine;
using System.Collections;

public class SpikeBall : MonoBehaviour {

    public float velocity;
    public float rotationVal;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            Application.LoadLevel(Application.loadedLevelName);
        }
        if(coll.gameObject.tag == "Wall")
        {
            if(GetComponent<Rigidbody2D>().velocity.x >= 0)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.left * velocity;
            } else
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.right * velocity;
            }
            rotationVal *= -1;
        }
    }

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right*velocity;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        GetComponent<Transform>().Rotate(Vector3.forward, rotationVal);
    }
}
