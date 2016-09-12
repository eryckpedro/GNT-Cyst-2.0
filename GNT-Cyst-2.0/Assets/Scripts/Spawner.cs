using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour {

	public static bool acabeiMover;

	private GameObject prefab;


	public void gerarErvilha()
	{
		prefab = DragHandler.itemSendoGerado;

		if(acabeiMover)
		{
			GameObject tempErv = Instantiate(prefab, transform.position, 
			                                 transform.rotation) as GameObject;
			tempErv.transform.SetParent(DragHandler.parentInicial, false);
			acabeiMover = false;
		}
	}

	void Update()
	{
		gerarErvilha();
	}
}
