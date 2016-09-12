using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SlotManager : MonoBehaviour, IDropHandler {
	
	public bool slotComb;
	public static int numSlotCombPai;
	public int numSlotComb; 
	public bool slotDescarte;

	GeneCombiner geneComb;

	void Start()
	{
		geneComb = FindObjectOfType(typeof(GeneCombiner)) as GeneCombiner;
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
				DragHandler.itemSendoArrastado.transform.SetParent(transform, false);

				//Se for slot de combinacao, adiciona ao vetor de ervilhas na pos especifica
				if(this.slotComb)
					geneComb.vetorErvilhas[numSlotComb - 1] = DragHandler.itemSendoArrastado;


				if(!DragHandler.podeGerar)
					Spawner.acabeiMover = true;

				//Se o slot do pai FOR de combinacao, apaga o antigo e sobrescreve o novo
				else
				{
					geneComb.vetorErvilhas[numSlotComb - 1] = DragHandler.itemSendoArrastado;
					geneComb.vetorErvilhas[numSlotCombPai - 1] = null;
				}
			}
			else
			{
				if(DragHandler.podeGerar)
					Destroy(DragHandler.itemSendoArrastado);
			}
		}
	}

	#endregion
}
