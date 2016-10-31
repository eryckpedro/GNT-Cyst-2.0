using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	//Telas Ensino Fundamental
	public void EF_novaCombinacao()
	{
		resetaVariaveis();
		Application.LoadLevel("EF_TelaCombinacao");
	}

	public void EF_iniciaSimulacao()
	{
		Application.LoadLevel("EF_TelaCombinacao");
	}

	public void EF_telaTitulo()
	{
		GeneCombiner.numErvilhasGeradas = 0;
		Application.LoadLevel("EF_TelaInicial");
	}

	public void EF_telaInformacao()
	{
		Application.LoadLevel("EF_TelaInformacao");
	}

	public void EF_telaDesafio()
	{
		Application.LoadLevel("EF_TelaDesafio");
	}

	public void EF_acertouDesafio()
	{
		Application.LoadLevel("EF_TelaDesafioAcerto");
	}

	public void EF_errouDesafio()
	{
		Application.LoadLevel("EF_TelaDesafioErro");
	}


	//Telas Ensino Medio
	public void EM_telaTitulo()
	{
		Application.LoadLevel("EM_TelaInicial");
	}

	public void EM_PROB_telaInicial()
	{
		Application.LoadLevel("EM_PROB_TelaInicial");
	}


	//Outras Telas
	public void telaInicial()
	{
		Application.LoadLevel("TelaInicial");
	}
	
	public void telaSobreSwEdu()
	{
		Application.LoadLevel("TelaSobreSwEdu");
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
