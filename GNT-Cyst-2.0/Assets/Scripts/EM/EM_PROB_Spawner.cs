using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class EM_PROB_Spawner : MonoBehaviour {

	public static bool acabeiMover;

	private GameObject prefab;


	public void gerarErvilha()
	{
		prefab = EM_PROB_DragHandler.itemSendoGerado;

		if(acabeiMover)
		{
			GameObject tempErv = Instantiate(prefab, transform.position, 
			                                 transform.rotation) as GameObject;
			tempErv.transform.SetParent(EM_PROB_DragHandler.parentInicial, false);
			acabeiMover = false;
		}
	}

	void Update()
	{
		gerarErvilha();
	}
}
