using UnityEngine;
using System;
using System.Collections;
using System.Linq;
using Gengine;

/*
	Blob class created by Anthony Cloudy
*/

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
	public LABColor color;
	
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
	
	public void addGene<T> (string geneName, T allele1, T allele2)
	{
		Gene<T> gene = new Gene<T>(geneName, allele1, allele2);
		addGene<T> (gene);
	}
	
	public void addGene<T> (string geneName, T allele1, int dom1, T allele2, int dom2)
	{
		Gene<T> gene = new Gene<T>(geneName, allele1, dom1, allele2, dom2);
		addGene<T> (gene);
	}
	
	public Gene<T> getGene<T>(string name)
	{
		return DNA[name] as Gene<T>;
	}
}
