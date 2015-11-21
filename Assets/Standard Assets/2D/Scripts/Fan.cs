using UnityEngine;
using System.Collections;

public class Fan : MonoBehaviour {

    public float fanForce;
    public float fixedForce;
    public float forceCap;
    public float Equilibrium;
    public float Variance;
    private GameObject player;
    struct bounds
    {
        public float Max;
        public float Min;
    }

    void addForce(){
        Vector3 force = new Vector3(0, 0);
        float playerPosy = player.GetComponent<Transform>().position.y;
        float distance = Equilibrium - Variance/2 - playerPosy;  
        bounds playerX;
        playerX.Max = player.GetComponent<Renderer>().bounds.max.x;
        playerX.Min = player.GetComponent<Renderer>().bounds.min.x;
        float forceTemp = fanForce / (1.0f + distance * distance) * (playerX.Max - playerX.Min);
        if (playerPosy < Equilibrium - Variance)
            force.y = fixedForce;
        else
            force.y = forceTemp * 2;

        //if (distance < 0)
        //    fanForce = 0;
        ////float forceTemp = fanForce / (1.0f + distance * distance) * (playerX.Max - playerX.Min) * 23;
        //float forceTemp = fanForce / (distance * distance) * (playerX.Max - playerX.Min);
        //if (forceTemp > forceCap)
        //{
        //    force.y = forceCap;
        //} else
        //{
        //    force.y = forceTemp;
        //}
        Debug.Log("force added: " + force.y + "," + playerPosy);
        player.GetComponent<Rigidbody2D>().AddForce(force);
    }

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        Equilibrium += GetComponent<Transform>().position.y;
	}
	
	// Update is called once per frame
	void Update () {
        bounds fanX;
        fanX.Max = GetComponent<Renderer>().bounds.max.x;
        fanX.Min = GetComponent<Renderer>().bounds.min.x;
        float playerPosX = player.GetComponent<Transform>().position.x;
        if((playerPosX > fanX.Min) && (playerPosX < fanX.Max))
        {
            addForce();
        }
    }
}
