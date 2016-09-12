using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ResultSpawner : MonoBehaviour {

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
		int i;
		float verdAux, amarAux, amarHibAux;

		verdAux = GeneCombiner.numErvilhasGeradas * (GeneCombiner.mapaProbabilidades["aa"] / 100f);
		amarAux = GeneCombiner.numErvilhasGeradas * (GeneCombiner.mapaProbabilidades["AA"] / 100f);
		amarHibAux = GeneCombiner.numErvilhasGeradas * (GeneCombiner.mapaProbabilidades["Aa"] / 100f);

		numErvilhasVerdes = (int) verdAux;
		numErvilhasAmarelas = (int) amarAux;
		numErvilhasAmarelasHib = (int) amarHibAux;

		for(i = 0; i < numErvilhasVerdes; i++)
			geraErvilhasVerdes();

		for(i = 0; i < numErvilhasAmarelas; i++)
			geraErvilhasAmarelas();

		for(i = 0; i < numErvilhasAmarelasHib; i++)
			geraErvilhasAmarelasHib();
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
