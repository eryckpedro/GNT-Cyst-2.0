using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class EM_PROB_ResultSpawner : MonoBehaviour {

	public GameObject ervilhaVerdePrefab;
	public GameObject ervilhaAmarelaPrefab;
	public GameObject ervilhaAmarelaHibPrefab;

	private int numErvilhasVerdes;
	private int numErvilhasAmarelas;
	private int numErvilhasAmarelasHib;

	void Start()
	{
		geraErvilhasResultantes();
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
}
