using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowProperties : MonoBehaviour {

	public string nome;
	public string alelo;
	public string tipo;
	public Text info;


	public void mostrarInfo()
	{
		info.text = 
			"Nome: " + nome + ".\n" + 
			"Alelo: " + alelo + ".\n" +
			"Tipo: " + tipo + ".\n";

	}

	public void apagarInfo()
	{
		info.text = "";
	}


}
