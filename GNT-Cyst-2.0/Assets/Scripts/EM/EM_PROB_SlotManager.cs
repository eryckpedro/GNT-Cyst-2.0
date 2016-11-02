using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class EM_PROB_SlotManager : MonoBehaviour, IDropHandler {
	
	public bool slotComb;
	public static int numSlotCombPai;
	public int numSlotComb; 
	public bool slotDescarte;

	EM_PROB_GeneCombiner geneComb;

	void Start()
	{
		geneComb = FindObjectOfType(typeof(EM_PROB_GeneCombiner)) as EM_PROB_GeneCombiner;
		geneComb.vetorErvilhas = new GameObject[2];
	}

	public GameObject item
	{
		get
		{
			if(transform.childCount > 0)
				return transform.GetChild(0).gameObject;

			return null;
		}
	}

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{

		if(!item) //Se o slot estiver vazio
		{
			if(!slotDescarte)
			{
				EM_PROB_DragHandler.itemSendoArrastado.transform.SetParent(transform, false);

				//Se for slot de combinacao, adiciona ao vetor de ervilhas na pos especifica
				if(this.slotComb)
					geneComb.vetorErvilhas[numSlotComb - 1] = EM_PROB_DragHandler.itemSendoArrastado;


				if(!EM_PROB_DragHandler.podeGerar)
					EM_PROB_Spawner.acabeiMover = true;

				//Se o slot do pai FOR de combinacao, apaga o antigo e sobrescreve o novo
				else
				{
					geneComb.vetorErvilhas[numSlotComb - 1] = EM_PROB_DragHandler.itemSendoArrastado;
					geneComb.vetorErvilhas[numSlotCombPai - 1] = null;
				}
			}
			else
			{
				if(EM_PROB_DragHandler.podeGerar)
					Destroy(EM_PROB_DragHandler.itemSendoArrastado);
			}
		}
	}

	#endregion
}
