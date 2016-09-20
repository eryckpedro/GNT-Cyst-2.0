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

	public void telaTituloEF()
	{
		GeneCombiner.numErvilhasGeradas = 0;
		Application.LoadLevel("TelaInicialEF");
	}

	public void telaTituloEM()
	{
		Application.LoadLevel("TelaInicialEM");
	}

	public void telaInicial()
	{
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
