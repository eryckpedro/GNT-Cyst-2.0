using UnityEngine;
using System.Collections;

public class EM_PROB_ResultNumberSetter : MonoBehaviour {

	public int numErvilhas;

	public void setaNumErvilhas()
	{
		EM_PROB_GeneCombiner.numErvilhasGeradas = numErvilhas;
	}
}
