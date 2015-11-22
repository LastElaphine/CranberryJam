using UnityEngine;
using System.Collections;

public class CameraOverview : MonoBehaviour {
    public float size;
    public float positionX;
    public float positionY;
    public float changeSpeed;
    public float timeLeft;
    private float sizeEnd;
    private float positonXEnd;
    private float positonYEnd;

    // Use this for initialization
    void Start () {
        sizeEnd = GetComponent<Camera>().orthographicSize;
        positonXEnd = GetComponent<Transform>().position.x;
        positonYEnd = GetComponent<Transform>().position.y;

        GetComponent<Camera>().orthographicSize = size;
        GetComponent<Transform>().position = new Vector2(positionX, positionY);
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0) {
            if (GetComponent<Camera>().orthographicSize > sizeEnd)
            {
                GetComponent<Camera>().orthographicSize -= changeSpeed;
            }
            if(GetComponent<Transform>().position.x > positonXEnd)
            {
                GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x - changeSpeed * 10, GetComponent<Transform>().position.y);
            } else
            {
                GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x + changeSpeed * 10, GetComponent<Transform>().position.y);
            }
            if (GetComponent<Transform>().position.y > positonXEnd)
            {
                GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y - changeSpeed * 10);
            }
            else
            {
                GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + changeSpeed * 10);
            }
        }
	}
}
