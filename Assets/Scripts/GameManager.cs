using UnityEngine;
using System.Collections;
using RandoMazes.Languages; 

public class GameManager : MonoBehaviour {


	public Maze mazePrefab; 

	private Maze mazeInstance; 

	private Lang language;  

	// Use this for initialization
	void Start () {
		language = new Lang ("Spanish", "Assets/Languages/Spanish.xml");
		BeginGame ();
		//Debug.Log (language.getString ("welcome"));  
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			RestartGame ();
		}
	
	}

	private void BeginGame() {
		mazeInstance = Instantiate(mazePrefab) as Maze;
		StartCoroutine(mazeInstance.Generate ()); 
	}
	private void RestartGame() {
		StopAllCoroutines (); 
		Destroy(mazeInstance.gameObject);
		BeginGame();
	}
}
