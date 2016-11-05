using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EM_PROB_GeneCombiner : MonoBehaviour {

	public int tipoElemento;

	public static int tipoElementoCombinado;
	public GameObject[] vetorErvilhas;
	public static Dictionary<string, int> mapaProbabilidades;
	public static Dictionary<string, float> mapaProbabilidades2;
	public static int numErvilhasGeradas;

	private List<string> resultado;

	private string alelo1;
	private string alelo2;
	private char[] vetorGene1;
	private char[] vetorGene2;


	public void geraCombinacao()
	{
		tipoElementoCombinado = tipoElemento;

		preencheCampos();

		if( tipoElementoCombinado == 1)
		{
			combinaAlelos();
			Application.LoadLevel("EM_PROB_TelaResultado");
		}

		if( tipoElementoCombinado == 2)
		{
			combinaAlelosMaravilha();
			Application.LoadLevel("EM_PLM_TelaResultado");
		}

		if( tipoElementoCombinado == 3)
		{
			combinaAlelosHemacia();
			Application.LoadLevel("EM_PLM_ABO_TelaResultado");
		}

		if( tipoElementoCombinado == 4)
		{
			combinaAlelosSLM();
			Application.LoadLevel("EM_SLM_TelaResultado");
		}
		
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
		mapaProbabilidades2 = new Dictionary<string, float>();
	}

	void combinaAlelosSLM()
	{
		float probAlelo_AARR = 0, probAlelo_AARr = 0, probAlelo_AArr = 0, probAlelo_AaRR = 0, probAlelo_AaRr = 0, probAlelo_Aarr = 0;
		float probAlelo_aaRR = 0, probAlelo_aaRr = 0, probAlelo_aarr = 0;

		string[] vetorAlelos1 = new string[4];
		string[] vetorAlelos2 = new string[4];


		int cont = 0;
		for(int i = 0; i < 2; i++)
		{
			for(int j = 0; j < 2; j++)
			{
				string tempRes = vetorGene1[i].ToString() + vetorGene2[j].ToString();

				if(tempRes.Equals("aA")) tempRes = "Aa";

				vetorAlelos1[cont] = tempRes;
				cont++;
			}
		}

		cont = 0;
		for(int i = 2; i < 4; i++)
		{
			for(int j = 2; j < 4; j++)
			{
				string tempRes = vetorGene1[i].ToString() + vetorGene2[j].ToString();
				
				if(tempRes.Equals("rR")) tempRes = "Rr";

				vetorAlelos2[cont] = tempRes;
				cont++;
			}
		}


		for(int i = 0; i < 4; i++)
		{
			for(int j = 0; j < 4; j++)
			{
				string tempRes = vetorAlelos1[i] + vetorAlelos2[j];

				switch(tempRes)
				{
				case "AARR":
					probAlelo_AARR += 6.25f;
					break;
				case "AARr":
					probAlelo_AARr += 6.25f;
					break;
				case "AArr":
					probAlelo_AArr += 6.25f;
					break;
				case "AaRR":
					probAlelo_AaRR += 6.25f;
					break;
				case "AaRr":
					probAlelo_AaRr += 6.25f;
					break;
				case "Aarr":
					probAlelo_Aarr += 6.25f;
					break;
				case "aaRR":
					probAlelo_aaRR += 6.25f;
					break;
				case "aaRr":
					probAlelo_aaRr += 6.25f;
					break;
				case "aarr":
					probAlelo_aarr += 6.25f;
					break;
					
				}
			}
		}

		mapaProbabilidades2.Add("AARR", probAlelo_AARR);
		mapaProbabilidades2.Add("AARr", probAlelo_AARr);
		mapaProbabilidades2.Add("AArr", probAlelo_AArr);
		mapaProbabilidades2.Add("AaRR", probAlelo_AaRR);
		mapaProbabilidades2.Add("AaRr", probAlelo_AaRr);
		mapaProbabilidades2.Add("Aarr", probAlelo_Aarr);
		mapaProbabilidades2.Add("aaRR", probAlelo_aaRR);
		mapaProbabilidades2.Add("aaRr", probAlelo_aaRr);
		mapaProbabilidades2.Add("aarr", probAlelo_aarr);
	}
	
	void combinaAlelos()
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

	void combinaAlelosMaravilha()
	{
		int probAlelo_BB = 0, probAlelo_VV = 0, probAlelo_VB = 0;
		
		for(int i = 0; i < 2; i++)
		{
			for(int j = 0; j < 2; j++)
			{
				string tempRes = vetorGene1[i].ToString() + vetorGene2[j].ToString();
				
				if(tempRes == "BV") tempRes = "VB"; //Aplicando a convencao adotada
				
				switch(tempRes)
				{
				case "BB":
					probAlelo_BB += 25;
					break;
					
				case "VV":
					probAlelo_VV += 25;
					break;
					
				case "VB":
					probAlelo_VB += 25;
					break;
				}
				
				resultado.Add(tempRes);
				
			}
		}
		
		mapaProbabilidades.Add("BB", probAlelo_BB);
		mapaProbabilidades.Add("VV", probAlelo_VV);
		mapaProbabilidades.Add("VB", probAlelo_VB);
	}

	void combinaAlelosHemacia()
	{
		int probAlelo_IaIa = 0, probAlelo_Iai = 0, probAlelo_IbIb = 0, probAlelo_Ibi = 0, probAlelo_IaIb = 0, probAlelo_ii = 0;
		
		string alelo1A, alelo2A, alelo1B = "", alelo2B = "";
		
		string[] vetorAlelos1 = new string[2];
		string[] vetorAlelos2 = new string[2];
		
		
		alelo1A = vetorGene1[0].ToString() + vetorGene1[1].ToString();
		
		if(vetorGene1.Length > 2)
			alelo1B = vetorGene1[2].ToString() + vetorGene1[3].ToString();
		
		alelo2A = vetorGene2[0].ToString() + vetorGene2[1].ToString();
		
		if(vetorGene2.Length > 2)
			alelo2B = vetorGene2[2].ToString() + vetorGene2[3].ToString();
		
		if(alelo1A.Equals("ii"))
		{
			alelo1A = "i"; 
			alelo1B = "i";
		}
		
		if(alelo2A.Equals("ii"))
		{
			alelo2A = "i"; 
			alelo2B = "i";
		}
		
		alelo1A = alelo1A.Replace(" ", string.Empty);
		alelo1B = alelo1B.Replace(" ", string.Empty);
		alelo2A = alelo2A.Replace(" ", string.Empty);
		alelo2B = alelo2B.Replace(" ", string.Empty);
		
		vetorAlelos1[0] = alelo1A; vetorAlelos1[1] = alelo1B;
		vetorAlelos2[0] = alelo2A; vetorAlelos2[1] = alelo2B;
		
		for(int i = 0; i < 2; i++)
		{
			for(int j = 0; j < 2; j++)
			{
				string tempRes = vetorAlelos1[i] + vetorAlelos2[j];
				
				if(tempRes.Equals("IbIa")) tempRes = "IaIb";
				if(tempRes.Equals("iIa")) tempRes = "Iai";
				if(tempRes.Equals("iIb")) tempRes = "Ibi";
				
				switch(tempRes)
				{
				case "IaIa":
					probAlelo_IaIa += 25;
					break;
				case "IaIb":
					probAlelo_IaIb += 25;
					break;
				case "Iai":
					probAlelo_Iai += 25;
					break;
				case "IbIb":
					probAlelo_IbIb += 25;
					break;
				case "Ibi":
					probAlelo_Ibi += 25;
					break;
				case "ii":
					probAlelo_ii += 25;
					break;
					
				}
			}
		}
		
		
		mapaProbabilidades.Add("IaIa", probAlelo_IaIa);
		mapaProbabilidades.Add("IaIb", probAlelo_IaIb);
		mapaProbabilidades.Add("Iai", probAlelo_Iai);
		mapaProbabilidades.Add("IbIb", probAlelo_IbIb);
		mapaProbabilidades.Add("Ibi", probAlelo_Ibi);
		mapaProbabilidades.Add("ii", probAlelo_ii);
		
		
	}
}
