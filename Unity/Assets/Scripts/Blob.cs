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
	
	//Method that determines what to do with the two color alleles. Should there be codominance?
	public void setColor()
	{
		Gene<LABColor> gene = this.getGene<LABColor>("Color");
		
		//Codominance: Linear interpolation of both colors
		if (gene.alleleA.dominance == gene.alleleB.dominance)
		{
			this.color = LABColor.Lerp(gene.alleleA.value, gene.alleleB.value, 0.5f);
			return;
		}
		//Dominance: One attribute masks the other
		else if (gene.alleleA.dominance > gene.alleleB.dominance)
		{
			this.color = gene.alleleA.value;
		}
		
		else
		{
			this.color = gene.alleleB.value;
		}
		
	}
}
