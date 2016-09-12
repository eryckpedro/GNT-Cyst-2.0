using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	Vector3 posInicial;

	public static GameObject itemSendoArrastado;
	public static GameObject itemSendoGerado;
	public static Transform parentInicial;

	public static bool podeGerar; //Diz se o slot pai inicial da ervilha e de combinacao

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		itemSendoArrastado = gameObject;
		itemSendoGerado = itemSendoArrastado;
		posInicial = transform.position;
		parentInicial = transform.parent;

		GetComponent<CanvasGroup>().blocksRaycasts = false;
		podeGerar = gameObject.GetComponentInParent<SlotManager>().slotComb;
		SlotManager.numSlotCombPai = gameObject.GetComponentInParent<SlotManager>().numSlotComb;

	}

	#endregion


	#region IDragHandler implementation
	public void OnDrag (PointerEventData eventData)
	{
		transform.position = Input.mousePosition;
	}

	#endregion


	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		itemSendoArrastado = null;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
		if(transform.parent == parentInicial) { transform.position = posInicial; }
	}

	#endregion
}
