using UnityEngine;
using System.Collections;

public class HasKey : MonoBehaviour {

    public bool keyObtained = false;
    public Material activeMaterial;
    private GameObject Persistant;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (keyObtained)
            {
                Persistant = GameObject.Find("PersistantDataSource");
                Persistant.GetComponent<PersistantData>().currentLevel++;
                Persistant.GetComponent<PersistantData>().restartFlag = false;
                Application.LoadLevel(Persistant.GetComponent<PersistantData>().currentLevel);
            }
        }
        
    }

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
