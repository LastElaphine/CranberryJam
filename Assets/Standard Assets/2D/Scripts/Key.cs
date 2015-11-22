using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {
    public GameObject door;
    bool pickup;
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (pickup)
            {

                door.GetComponent<HasKey>().keyObtained = true;
                this.GetComponent<AudioSource>().Play();
                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                Destroy(this.gameObject.GetComponent<SpriteRenderer>());
                //Destroy(this.gameObject);
                Debug.Log("Key Obtained");
            }
        }

    }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        pickup = Input.GetButton("Pickup");
    }
}
