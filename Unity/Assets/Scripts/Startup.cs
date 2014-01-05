using UnityEngine;
using System.Collections;

public class Startup : MonoBehaviour {

	public GameObject mom;
	public GameObject dad;
	// Use this for initialization
	void Start () 
	{
		mom = (GameObject)Instantiate(Resources.Load("Blob"));
		dad = (GameObject)Instantiate(Resources.Load("Blob"));
		
		mom.transform.position = new Vector2(3, transform.position.y);
		dad.transform.position = new Vector2(-3, transform.position.y);
		
		mom.transform.eulerAngles = new Vector2(0, 180);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
