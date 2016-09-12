using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public void novaCombinacao()
	{
		resetaVariaveis();
		Application.LoadLevel("TelaCombinacao");
	}

	public void iniciaSimulacao()
	{
		Application.LoadLevel("TelaCombinacao");
	}

	public void telaTitulo()
	{
		GeneCombiner.numErvilhasGeradas = 0;
		Application.LoadLevel("TelaInicial");
	}

	public void telaInformacao()
	{
		Application.LoadLevel("TelaInformacao");
	}

	public void telaDesafio()
	{
		Application.LoadLevel("TelaDesafio");
	}

	public void acertouDesafio()
	{
		Application.LoadLevel("TelaDesafioAcerto");
	}

	public void errouDesafio()
	{
		Application.LoadLevel("TelaDesafioErro");
	}

	public void encerraAplicativo()
	{
		Application.Quit();
	}

	void resetaVariaveis()
	{
		GeneCombiner.mapaProbabilidades.Clear();
		GeneCombiner.numErvilhasGeradas = 0;
	}
}
