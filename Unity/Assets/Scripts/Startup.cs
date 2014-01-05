using UnityEngine;
using System.Collections;
using Gengine;

public class Startup : MonoBehaviour {

	public GameObject mom;
	public GameObject dad;
	public GameObject child;
	public GameObject GO;
	public float distance = -3.0f;
	// Use this for initialization
	void Start () 
	{
		mom = (GameObject)Instantiate(Resources.Load("Blob"));
		dad = (GameObject)Instantiate(Resources.Load("Blob"));
		
		//Separate the two so they aren't covering each other
		mom.transform.position = new Vector2(3, transform.position.y);
		dad.transform.position = new Vector2(-3, transform.position.y);
		
		//Add markings to the dad
		//GO = (GameObject)Instantiate(Resources.Load("dogmarkings"));
		//GO.transform.parent = dad.transform;
		//GO.transform.position = new Vector3(-3, transform.position.y, -1);
		
		//Flip the Mommy around so that she faces the Daddy
		mom.transform.eulerAngles = new Vector2(0, 180);
		
		//Make the Mom red and the Dad green
		LABColor c1 = new LABColor(Color.yellow);
		LABColor c2 = new LABColor(Color.red);
		LABColor c3 = new LABColor(Color.white);
		LABColor c4 = new LABColor(Color.black);
		mom.GetComponent<SpriteRenderer>().color = c1.ToColor();
		dad.GetComponent<SpriteRenderer>().color = c2.ToColor();
		
		mom.GetComponent<Blob>().addGene<LABColor>("Color", c1, 0, c3, 0);
		dad.GetComponent<Blob>().addGene<LABColor>("Color", c2, 0, c4, 0);
		
		child = Punnett.cross(mom.GetComponent<Blob>(), dad.GetComponent<Blob>());
		child.transform.position = new Vector2(0, transform.position.y);
		
		child.GetComponent<SpriteRenderer>().color = child.GetComponent<Blob>().color.ToColor();

	}
	
	// Update is called once per frame
	void Update () 
	{
		//distance += 0.1f;
		//dad.transform.position = new Vector2(distance , transform.position.y);
	}
}
