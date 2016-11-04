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
