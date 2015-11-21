using UnityEngine;
using System.Collections;

public class ChangeGravity : MonoBehaviour {

    public GameObject target;
    public float gravity;
    private Rigidbody2D playerRB;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            playerRB = target.GetComponent<Rigidbody2D>();
            playerRB.gravityScale = gravity;
            Destroy(this.gameObject);
            Debug.Log("gravity changed to: " + gravity);
        }
            
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
