using UnityEngine;
using System.Collections;

public class ResultNumberSetter : MonoBehaviour {

	public int numErvilhas;

	public void setaNumErvilhas()
	{
		GeneCombiner.numErvilhasGeradas = numErvilhas;
	}
}
