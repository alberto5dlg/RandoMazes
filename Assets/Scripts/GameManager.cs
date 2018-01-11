using UnityEngine;
using System.Collections;
using RandoMazes.Languages; 

public class GameManager : MonoBehaviour {


	private Lang language;  

	// Use this for initialization
	void Start () {
		BeginGame ();
		language = new Lang ("Spanish", "Assets/Languages/Spanish.xml"); 
		Debug.Log (language.getString ("welcome")); 
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
