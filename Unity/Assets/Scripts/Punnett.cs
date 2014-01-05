using UnityEngine;
using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Gengine
{
	public class Punnett : MonoBehaviour
	{
	
		public static System.Random random;
		
		void Awake()
		{
			DontDestroyOnLoad(this);
			random = new System.Random();
		}

        public static Gene<T> cross<T>(Gene<T> g1, Gene<T> g2)
        {
            string name;
			if (g1.geneName != g2.geneName)
				return null; //Error: Names don't match
            else
				name = g1.geneName;

			int randomNumber = random.Next(1, 5);
            Gene<T> offspring;

            if (randomNumber == 1)
                if (g1.alleleA.dominance >= g2.alleleA.dominance)
                    offspring = new Gene<T>(name, g1.alleleA, g2.alleleA);
                else
                    offspring = new Gene<T>(name, g2.alleleA, g1.alleleA);

            else if (randomNumber == 2)
                if (g1.alleleA.dominance >= g2.alleleB.dominance)
                    offspring = new Gene<T>(name, g1.alleleA, g2.alleleB);
                else
                    offspring = new Gene<T>(name, g2.alleleB, g1.alleleA);

            else if (randomNumber == 3)
                if (g1.alleleB.dominance >= g2.alleleA.dominance)
                    offspring = new Gene<T>(name, g1.alleleB, g2.alleleA);
                else
                    offspring = new Gene<T>(name, g2.alleleA, g1.alleleB);

            else
                if (g1.alleleB.dominance >= g2.alleleB.dominance)
                    offspring = new Gene<T>(name, g1.alleleB, g2.alleleB);
                else
                    offspring = new Gene<T>(name, g2.alleleB, g1.alleleB);

            return offspring;
        }

		//This one is hard coded for the time being. Still thinking of a dynamic solution.
        public static GameObject cross(Blob mom, Blob dad)
        {

			GameObject offspring = (GameObject)Instantiate(Resources.Load("Blob"));
			                                         
			if (mom.numGenes == dad.numGenes)
            {
				offspring.GetComponent<Blob>().addGene<LABColor>(cross<LABColor>(mom.getGene<LABColor>("Color"), dad.getGene<LABColor>("Color")));
				offspring.GetComponent<Blob>().color = LABColor.Lerp(offspring.GetComponent<Blob>().getGene<LABColor>("Color").alleleA.value,
				                                                     offspring.GetComponent<Blob>().getGene<LABColor>("Color").alleleB.value, 
				                                                     0.5f);
                return offspring;
            }

            else
            {
                return null;
            }
        }
    }
    
	public class Gene<T>
	{
		public Allele<T> alleleA;
		public Allele<T> alleleB;
		public string geneName;
		
		public Gene(string n, Allele<T> input1, Allele<T> input2)
		{
			geneName = n;
			alleleA = input1;
			alleleB = input2;
		}
		
		public Gene (string n, T input1, T input2)
		{
			geneName = n;
			this.alleleA = new Allele<T> (input1);
			this.alleleB = new Allele<T> (input2);
		}
		
		public Gene(string n, T input1, int dom1, T input2, int dom2)
		{
			geneName = n;
			this.alleleA = new Allele<T>(input1, dom1);
			this.alleleB = new Allele<T>(input2, dom2);
		}
	}
	
	public class Allele<T> 
	{
		public T value;
		public int dominance;
		
		public Allele(T input)
		{
			value = input;
			dominance = 0;
		}
		
		public Allele(T input, int dom)
		{
			value = input;
			dominance = dom;
		}
	}
}
