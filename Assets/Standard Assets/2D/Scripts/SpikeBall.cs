using UnityEngine;
using System.Collections;

public class SpikeBall : MonoBehaviour {

    public float velocity;
    public float rotationVal;
    //private bool dir = true;
    void OnCollisionEnter2D(Collision2D coll)
    {
        var contacts = coll.contacts[0];
        if(coll.gameObject.tag == "Player")
        {
            Application.LoadLevel(Application.loadedLevelName);
        }
        if(coll.gameObject.tag == "Wall")
        {
            Debug.Log(GetComponent<Rigidbody2D>().velocity.x);
            if (contacts.point.x < GetComponent<Transform>().position.x)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(velocity, 0);
                //dir = false;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-velocity, 0);
                //dir = true;
            }
            Debug.Log(GetComponent<Rigidbody2D>().velocity.x);
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
