using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		BeginGame ();
		Debug.Log (); 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			RestartGame ();
		}
	
	}

	private void BeginGame() {}
	private void RestartGame() {}
}
