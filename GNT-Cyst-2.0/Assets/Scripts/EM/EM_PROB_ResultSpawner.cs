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

	private int numErvilhasVerdes;
	private int numErvilhasAmarelas;
	private int numErvilhasAmarelasHib;

	private int numMaravilhasBrancas;
	private int numMaravilhasVermelhas;
	private int numMaravilhasRosas;

	void Start()
	{
		if(EM_PROB_GeneCombiner.tipoElementoCombinado == 1)
			geraErvilhasResultantes();

		if(EM_PROB_GeneCombiner.tipoElementoCombinado == 2)
			geraMaravilhasResultantes();
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
