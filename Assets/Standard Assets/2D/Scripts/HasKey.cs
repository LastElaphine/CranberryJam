using UnityEngine;
using System.Collections;

public class HasKey : MonoBehaviour {

    public bool keyObtained = false;
    public Material activeMaterial;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (keyObtained)
        {
            GetComponent<Renderer>().material = activeMaterial;
        }
    }
}
