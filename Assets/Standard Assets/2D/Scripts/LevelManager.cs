using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadScene(){
		Application.LoadLevel (1);
	}

	public void Quit(){
		Application.Quit ();
	}
}
