using UnityEngine;
using System.Collections;
using System.Linq;
using Gengine;

public class Blob : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public enum Gender { Male, Female }
	public int gender;
	public int numGenes = 0;
	
	private SortedList DNA = new SortedList();
	
	
	public Blob(Gene<char> input)
	{
		addGene<char>(input);
	}
	
	public Blob()
	{
		gender = 1;
	}
	
	public void addGene<T>(Gene<T> gene)
	{
		DNA.Add(gene.geneName, gene);
		numGenes++;
	}
	
	public Gene<T> getGene<T>(string name)
	{
		return DNA[name] as Gene<T>;
	}
}
