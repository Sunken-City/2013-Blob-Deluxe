using UnityEngine;
using System.Collections;
using Gengine;

public class Startup : MonoBehaviour {

	public GameObject mom;
	public GameObject dad;
	public GameObject child;
	// Use this for initialization
	void Start () 
	{
		mom = (GameObject)Instantiate(Resources.Load("Blob"));
		dad = (GameObject)Instantiate(Resources.Load("Blob"));
		
		//Separate the two so they aren't covering each other
		mom.transform.position = new Vector2(3, transform.position.y);
		dad.transform.position = new Vector2(-3, transform.position.y);
		
		//Flip the Mommy around so that she faces the Daddy
		mom.transform.eulerAngles = new Vector2(0, 180);
		
		//Make the Mom red and the Dad green
		LABColor c1 = new LABColor(Color.blue);
		LABColor c2 = new LABColor(Color.white);
		mom.GetComponent<SpriteRenderer>().color = c1.ToColor();
		dad.GetComponent<SpriteRenderer>().color = c2.ToColor();
		
		mom.GetComponent<Blob>().addGene<LABColor>("Color", c1, c1);
		dad.GetComponent<Blob>().addGene<LABColor>("Color", c2, c2);
		
		child = Punnett.cross(mom.GetComponent<Blob>(), dad.GetComponent<Blob>());
		child.transform.position = new Vector2(0, transform.position.y);
		
		child.GetComponent<SpriteRenderer>().color = child.GetComponent<Blob>().color.ToColor();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
