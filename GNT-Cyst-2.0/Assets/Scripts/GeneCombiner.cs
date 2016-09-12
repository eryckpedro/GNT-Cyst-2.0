using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GeneCombiner : MonoBehaviour {

	public GameObject[] vetorErvilhas;
	public static Dictionary<string, int> mapaProbabilidades;
	public static int numErvilhasGeradas;

	private List<string> resultado;

	private string alelo1;
	private string alelo2;
	private char[] vetorGene1;
	private char[] vetorGene2;


	public void geraCombinacao()
	{
		preencheCampos();
		
		combinaAlelos();
		
		Application.LoadLevel("TelaResultado");
		
	}

	void Update()
	{
		if(vetorErvilhas[0] && vetorErvilhas[1] && numErvilhasGeradas > 0)
			gameObject.GetComponent<Button>().interactable = true;
		else
			gameObject.GetComponent<Button>().interactable = false;
	}

	void preencheCampos()
	{
		alelo1 = vetorErvilhas[0].GetComponent<ShowProperties>().alelo;
		alelo2 = vetorErvilhas[1].GetComponent<ShowProperties>().alelo;

		vetorGene1 = alelo1.ToCharArray();
		vetorGene2 = alelo2.ToCharArray();
		
		resultado = new List<string>();
		mapaProbabilidades = new Dictionary<string, int>();
	}

	void combinaAlelos ()
	{
		int probAlelo_aa = 0, probAlelo_AA = 0, probAlelo_Aa = 0;

		for(int i = 0; i < 2; i++)
		{
			for(int j = 0; j < 2; j++)
			{
				string tempRes = vetorGene1[i].ToString() + vetorGene2[j].ToString();
				
				if(tempRes == "aA") tempRes = "Aa"; //Aplicando a convencao adotada

				switch(tempRes)
				{
					case "aa":
						probAlelo_aa += 25;
						break;

					case "AA":
						probAlelo_AA += 25;
						break;

					case "Aa":
						probAlelo_Aa += 25;
						break;
				}
				
				resultado.Add(tempRes);

			}
		}

		mapaProbabilidades.Add("aa", probAlelo_aa);
		mapaProbabilidades.Add("AA", probAlelo_AA);
		mapaProbabilidades.Add("Aa", probAlelo_Aa);
	}

}
