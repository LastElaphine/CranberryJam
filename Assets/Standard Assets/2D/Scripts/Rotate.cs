using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public float rotationVal;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        GetComponent<Transform>().Rotate(Vector3.forward, rotationVal);
    }
}
