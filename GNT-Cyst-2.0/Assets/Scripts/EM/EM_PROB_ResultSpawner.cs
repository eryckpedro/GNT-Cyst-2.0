using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class EM_PROB_ResultSpawner : MonoBehaviour {

	public GameObject ervilhaVerdePrefab;
	public GameObject ervilhaAmarelaPrefab;
	public GameObject ervilhaAmarelaHibPrefab;

	public GameObject maravilhaBrancaPrefab;
	public GameObject maravilhaVermelhaPrefab;
	public GameObject maravilhaRosaPrefab;

	public GameObject hemIaIaPrefab;
	public GameObject hemIaIbPrefab;
	public GameObject hemIaiPrefab;
	public GameObject hemIbIbPrefab;
	public GameObject hemIbiPrefab;
	public GameObject hemiiPrefab;

	public GameObject ervAARRPrefab;
	public GameObject ervAARrPrefab;
	public GameObject ervAArrPrefab;
	public GameObject ervAaRRPrefab;
	public GameObject ervAaRrPrefab;
	public GameObject ervAarrPrefab;
	public GameObject ervaaRRPrefab;
	public GameObject ervaaRrPrefab;
	public GameObject ervaarrPrefab;

	private int numErvilhasVerdes;
	private int numErvilhasAmarelas;
	private int numErvilhasAmarelasHib;

	private int numMaravilhasBrancas;
	private int numMaravilhasVermelhas;
	private int numMaravilhasRosas;

	private int numHemIaIa;
	private int numHemIaIb;
	private int numHemIai;
	private int numHemIbIb;
	private int numHemIbi;
	private int numHemii;

	void Start()
	{
		if(EM_PROB_GeneCombiner.tipoElementoCombinado == 1)
			geraErvilhasResultantes();

		if(EM_PROB_GeneCombiner.tipoElementoCombinado == 2)
			geraMaravilhasResultantes();

		if(EM_PROB_GeneCombiner.tipoElementoCombinado == 3)
			geraHemaciasResultantes();

		if(EM_PROB_GeneCombiner.tipoElementoCombinado == 4)
			geraErvilhasSLMResultantes();
	}

	public void geraErvilhasSLMResultantes()
	{
		int i, pos;
		int[] vetorProbabilidades = new int[EM_PROB_GeneCombiner.numErvilhasGeradas];

		int numervAARR, numervAARr, numervAArr, numervAaRR, numervAaRr, numervAarr;
		int numervaaRR, numervaaRr, numervaarr;

		
		float ervAARR_Aux, ervAARr_Aux, ervAArr_Aux, ervAaRR_Aux, ervAaRr_Aux, ervAarr_Aux;
		float ervaaRR_Aux, ervaaRr_Aux, ervaarr_Aux;

		ervAARR_Aux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades2["AARR"] / 100f);
		ervAARr_Aux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades2["AARr"] / 100f);
		ervAArr_Aux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades2["AArr"] / 100f);
		ervAaRR_Aux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades2["AaRR"] / 100f);
		ervAaRr_Aux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades2["AaRr"] / 100f);
		ervAarr_Aux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades2["Aarr"] / 100f);
		ervaaRR_Aux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades2["aaRR"] / 100f);
		ervaaRr_Aux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades2["aaRr"] / 100f);
		ervaarr_Aux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades2["aarr"] / 100f);

		numervAARR = (int) ervAARR_Aux;
		numervAARr = (int) ervAARr_Aux;
		numervAArr = (int) ervAArr_Aux;
		numervAaRR = (int) ervAaRR_Aux;
		numervAaRr = (int) ervAaRr_Aux;
		numervAarr = (int) ervAarr_Aux;
		numervaaRR = (int) ervaaRR_Aux;
		numervaaRr = (int) ervaaRr_Aux;
		numervaarr = (int) ervaarr_Aux;

		pos = 0;
		for(i = 0; i < numervAARR; i++)
		{
			vetorProbabilidades[pos] = 1;
			pos++;
		}
		for(i = 0; i < numervAARr; i++)
		{
			vetorProbabilidades[pos] = 2;
			pos++;
		}
		for(i = 0; i < numervAArr; i++)
		{
			vetorProbabilidades[pos] = 3;
			pos++;
		}
		for(i = 0; i < numervAaRR; i++)
		{
			vetorProbabilidades[pos] = 4;
			pos++;
		}
		for(i = 0; i < numervAaRr; i++)
		{
			vetorProbabilidades[pos] = 5;
			pos++;
		}
		for(i = 0; i < numervAarr; i++)
		{
			vetorProbabilidades[pos] = 6;
			pos++;
		}
		for(i = 0; i < numervaaRR; i++)
		{
			vetorProbabilidades[pos] = 7;
			pos++;
		}
		for(i = 0; i < numervaaRr; i++)
		{
			vetorProbabilidades[pos] = 8;
			pos++;
		}
		for(i = 0; i < numervaarr; i++)
		{
			vetorProbabilidades[pos] = 9;
			pos++;
		}

		System.Random rnd = new System.Random();
		for(i = 0; i < EM_PROB_GeneCombiner.numErvilhasGeradas; i++)
		{
			int posVetorProb = rnd.Next(0, EM_PROB_GeneCombiner.numErvilhasGeradas);
			
			if( vetorProbabilidades[posVetorProb] == 1 )
				geraErvAARR();
			
			if( vetorProbabilidades[posVetorProb] == 2 )
				geraErvAARr();
			
			if( vetorProbabilidades[posVetorProb] == 3 )
				geraErvAArr();
			
			if( vetorProbabilidades[posVetorProb] == 4 )
				geraErvAaRR();
			
			if( vetorProbabilidades[posVetorProb] == 5 )
				geraErvAaRr();
			
			if( vetorProbabilidades[posVetorProb] == 6 )
				geraErvAarr();

			if( vetorProbabilidades[posVetorProb] == 7 )
				geraErvaaRR();

			if( vetorProbabilidades[posVetorProb] == 8 )
				geraErvaaRr();

			if( vetorProbabilidades[posVetorProb] == 9 )
				geraErvaarr();
			
		}

	}

	public void geraErvAARR()
	{
		GameObject ervAARR;
		
		ervAARR = Instantiate(ervAARRPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		ervAARR.transform.SetParent(gameObject.transform, false);
	}

	public void geraErvAARr()
	{
		GameObject ervAARr;
		
		ervAARr = Instantiate(ervAARrPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		ervAARr.transform.SetParent(gameObject.transform, false);
	}

	public void geraErvAArr()
	{
		GameObject ervAArr;
		
		ervAArr = Instantiate(ervAArrPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		ervAArr.transform.SetParent(gameObject.transform, false);
	}

	public void geraErvAaRR()
	{
		GameObject ervAaRR;
		
		ervAaRR = Instantiate(ervAaRRPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		ervAaRR.transform.SetParent(gameObject.transform, false);
	}

	public void geraErvAaRr()
	{
		GameObject ervAaRr;
		
		ervAaRr = Instantiate(ervAaRrPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		ervAaRr.transform.SetParent(gameObject.transform, false);
	}

	public void geraErvAarr()
	{
		GameObject ervAarr;
		
		ervAarr = Instantiate(ervAarrPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		ervAarr.transform.SetParent(gameObject.transform, false);
	}

	public void geraErvaaRR()
	{
		GameObject ervaaRR;
		
		ervaaRR = Instantiate(ervaaRRPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		ervaaRR.transform.SetParent(gameObject.transform, false);
	}

	public void geraErvaaRr()
	{
		GameObject ervaaRr;
		
		ervaaRr = Instantiate(ervaaRrPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		ervaaRr.transform.SetParent(gameObject.transform, false);
	}

	public void geraErvaarr()
	{
		GameObject ervaarr;
		
		ervaarr = Instantiate(ervaarrPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		ervaarr.transform.SetParent(gameObject.transform, false);
	}

	public void geraHemaciasResultantes()
	{
		int i, pos;
		int[] vetorProbabilidades = new int[EM_PROB_GeneCombiner.numErvilhasGeradas];
		
		float hemIaIaAux, hemIaIbAux, hemIaiAux, hemIbIbAux, hemIbiAux, hemiiAux;
		
		hemIaIaAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["IaIa"] / 100f);
		hemIaIbAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["IaIb"] / 100f);
		hemIaiAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["Iai"] / 100f);
		hemIbIbAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["IbIb"] / 100f);
		hemIbiAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["Ibi"] / 100f);
		hemiiAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["ii"] / 100f);
		
		numHemIaIa = (int) hemIaIaAux;
		numHemIaIb = (int) hemIaIbAux;
		numHemIai = (int) hemIaiAux;
		numHemIbIb = (int) hemIbIbAux;
		numHemIbi = (int) hemIbiAux;
		numHemii = (int) hemiiAux;
		
		pos = 0;
		for(i = 0; i < numHemIaIa; i++)
		{
			vetorProbabilidades[pos] = 1;
			pos++;
		}
		
		for(i = 0; i < numHemIaIb; i++)
		{
			vetorProbabilidades[pos] = 2;
			pos++;
		}
		
		for(i = 0; i < numHemIai; i++)
		{
			vetorProbabilidades[pos] = 3;
			pos++;
		}

		for(i = 0; i < numHemIbIb; i++)
		{
			vetorProbabilidades[pos] = 4;
			pos++;
		}
		
		for(i = 0; i < numHemIbi; i++)
		{
			vetorProbabilidades[pos] = 5;
			pos++;
		}
		
		for(i = 0; i < numHemii; i++)
		{
			vetorProbabilidades[pos] = 6;
			pos++;
		}
		
		
		System.Random rnd = new System.Random();
		for(i = 0; i < EM_PROB_GeneCombiner.numErvilhasGeradas; i++)
		{
			int posVetorProb = rnd.Next(0, EM_PROB_GeneCombiner.numErvilhasGeradas);
			
			if( vetorProbabilidades[posVetorProb] == 1 )
				geraHemIaIa();
			
			if( vetorProbabilidades[posVetorProb] == 2 )
				geraHemIaIb();
			
			if( vetorProbabilidades[posVetorProb] == 3 )
				geraHemIai();

			if( vetorProbabilidades[posVetorProb] == 4 )
				geraHemIbIb();

			if( vetorProbabilidades[posVetorProb] == 5 )
				geraHemIbi();

			if( vetorProbabilidades[posVetorProb] == 6 )
				geraHemii();
			
		}
	}

	public void geraHemIaIa()
	{
		GameObject hemIaIa;
		
		hemIaIa = Instantiate(hemIaIaPrefab, transform.position, 
		                           transform.rotation) as GameObject;
		
		hemIaIa.transform.SetParent(gameObject.transform, false);
	}

	public void geraHemIaIb()
	{
		GameObject hemIaIb;
		
		hemIaIb = Instantiate(hemIaIbPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		hemIaIb.transform.SetParent(gameObject.transform, false);
	}

	public void geraHemIai()
	{
		GameObject hemIai;
		
		hemIai = Instantiate(hemIaiPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		hemIai.transform.SetParent(gameObject.transform, false);
	}

	public void geraHemIbIb()
	{
		GameObject hemIbIb;
		
		hemIbIb = Instantiate(hemIbIbPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		hemIbIb.transform.SetParent(gameObject.transform, false);
	}

	public void geraHemIbi()
	{
		GameObject hemIbi;
		
		hemIbi = Instantiate(hemIbiPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		hemIbi.transform.SetParent(gameObject.transform, false);
	}

	public void geraHemii()
	{
		GameObject hemii;
		
		hemii = Instantiate(hemiiPrefab, transform.position, 
		                      transform.rotation) as GameObject;
		
		hemii.transform.SetParent(gameObject.transform, false);
	}


	public void geraErvilhasResultantes()
	{
		int i, pos;
		int[] vetorProbabilidades = new int[EM_PROB_GeneCombiner.numErvilhasGeradas];

		float verdAux, amarAux, amarHibAux;

		verdAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["aa"] / 100f);
		amarAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["AA"] / 100f);
		amarHibAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["Aa"] / 100f);

		numErvilhasVerdes = (int) verdAux;
		numErvilhasAmarelas = (int) amarAux;
		numErvilhasAmarelasHib = (int) amarHibAux;

		pos = 0;
		for(i = 0; i < numErvilhasVerdes; i++)
		{
			vetorProbabilidades[pos] = 1;
			pos++;
		}
		
		for(i = 0; i < numErvilhasAmarelas; i++)
		{
			vetorProbabilidades[pos] = 2;
			pos++;
		}
		
		for(i = 0; i < numErvilhasAmarelasHib; i++)
		{
			vetorProbabilidades[pos] = 3;
			pos++;
		}
		 

		System.Random rnd = new System.Random();
		for(i = 0; i < EM_PROB_GeneCombiner.numErvilhasGeradas; i++)
		{
			int posVetorProb = rnd.Next(0, EM_PROB_GeneCombiner.numErvilhasGeradas);

			if( vetorProbabilidades[posVetorProb] == 1 )
				geraErvilhasVerdes();

			if( vetorProbabilidades[posVetorProb] == 2 )
				geraErvilhasAmarelas();

			if( vetorProbabilidades[posVetorProb] == 3 )
				geraErvilhasAmarelasHib();

		}
	}


	public void geraErvilhasVerdes()
	{
		GameObject ervilhaVerde;

		ervilhaVerde = Instantiate(ervilhaVerdePrefab, transform.position, 
		                           transform.rotation) as GameObject;

		ervilhaVerde.transform.SetParent(gameObject.transform, false);
	}

	public void geraErvilhasAmarelas()
	{
		GameObject ervilhaAmarela;

		ervilhaAmarela = Instantiate(ervilhaAmarelaPrefab, transform.position, 
		                             transform.rotation) as GameObject;

		ervilhaAmarela.transform.SetParent(gameObject.transform, false);
	}

	public void geraErvilhasAmarelasHib()
	{
		GameObject ervilhaAmarelaHib;

		ervilhaAmarelaHib = Instantiate(ervilhaAmarelaHibPrefab, transform.position, 
		                                transform.rotation) as GameObject;

		ervilhaAmarelaHib.transform.SetParent(gameObject.transform, false);
	}


	public void geraMaravilhasResultantes()
	{
		int i, pos;
		int[] vetorProbabilidades = new int[EM_PROB_GeneCombiner.numErvilhasGeradas];
		
		float brancAux, vermAux, rosAux;
		
		brancAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["BB"] / 100f);
		vermAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["VV"] / 100f);
		rosAux = EM_PROB_GeneCombiner.numErvilhasGeradas * (EM_PROB_GeneCombiner.mapaProbabilidades["VB"] / 100f);
		
		numMaravilhasBrancas = (int) brancAux;
		numMaravilhasVermelhas = (int) vermAux;
		numMaravilhasRosas = (int) rosAux;
		
		pos = 0;
		for(i = 0; i < numMaravilhasBrancas; i++)
		{
			vetorProbabilidades[pos] = 1;
			pos++;
		}
		
		for(i = 0; i < numMaravilhasVermelhas; i++)
		{
			vetorProbabilidades[pos] = 2;
			pos++;
		}
		
		for(i = 0; i < numMaravilhasRosas; i++)
		{
			vetorProbabilidades[pos] = 3;
			pos++;
		}
		
		
		System.Random rnd = new System.Random();
		for(i = 0; i < EM_PROB_GeneCombiner.numErvilhasGeradas; i++)
		{
			int posVetorProb = rnd.Next(0, EM_PROB_GeneCombiner.numErvilhasGeradas);
			
			if( vetorProbabilidades[posVetorProb] == 1 )
				geraMaravilhasBrancas();
			
			if( vetorProbabilidades[posVetorProb] == 2 )
				geraMaravilhasVermelhas();
			
			if( vetorProbabilidades[posVetorProb] == 3 )
				geraMaravilhasRosas();
			
		}
	}

	public void geraMaravilhasBrancas()
	{
		GameObject maravilhaBranca;
		
		maravilhaBranca = Instantiate(maravilhaBrancaPrefab, transform.position, 
		                           transform.rotation) as GameObject;
		
		maravilhaBranca.transform.SetParent(gameObject.transform, false);
	}

	public void geraMaravilhasVermelhas()
	{
		GameObject maravilhaVermelha;
		
		maravilhaVermelha = Instantiate(maravilhaVermelhaPrefab, transform.position, 
		                              transform.rotation) as GameObject;
		
		maravilhaVermelha.transform.SetParent(gameObject.transform, false);
	}

	public void geraMaravilhasRosas()
	{
		GameObject maravilhaRosa;
		
		maravilhaRosa = Instantiate(maravilhaRosaPrefab, transform.position, 
		                              transform.rotation) as GameObject;
		
		maravilhaRosa.transform.SetParent(gameObject.transform, false);
	}
	
}
