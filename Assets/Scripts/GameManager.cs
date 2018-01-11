using UnityEngine;
using System.Collections;
using RandoMazes.Languages; 

public class GameManager : MonoBehaviour {


	private Lang language;  

	// Use this for initialization
	void Start () {
		BeginGame ();
		language = new Lang ("Spanish", "Assets/Languages/lang.xml"); 
		Debug.Log(language.getString("score_text")); 
		language.setLanguage ("Assets/Languages/lang.xml", "English");
		Debug.Log (language.getString ("score_text"));
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
