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

	public void EM_PROB_telaCombinacao()
	{
		Application.LoadLevel("EM_PROB_TelaCombinacao");
	}

	public void EM_PROB_novaCombinacao()
	{
		EM_PROB_resetaVariaveis();
		EM_PROB_telaCombinacao();
	}

	public void EM_PROB_telaInformacao()
	{
		Application.LoadLevel("EM_PROB_TelaInformacao");
	}


	public void EM_PLM_telaInicial()
	{
		Application.LoadLevel("EM_PLM_TelaInicial");
	}

	public void EM_PLM_telaCombinacao()
	{
		Application.LoadLevel("EM_PLM_TelaCombinacao");
	}

	public void EM_PLM_novaCombinacao()
	{
		EM_PROB_resetaVariaveis();
		EM_PLM_telaCombinacao();
	}

	public void EM_PLM_ABO_telaCombinacao()
	{
		Application.LoadLevel("EM_PLM_ABO_TelaCombinacao");
	}

	public void EM_PLM_ABO_novaCombinacao()
	{
		EM_PROB_resetaVariaveis();
		EM_PLM_ABO_telaCombinacao();
	}


	//Outras Telas
	public void telaInicial()
	{
		Application.LoadLevel("TelaInicial");
	}

	public void telaInfoGeral()
	{
		Application.LoadLevel("TelaInformacaoGeral");
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

	void EM_PROB_resetaVariaveis()
	{
		EM_PROB_GeneCombiner.mapaProbabilidades.Clear();
		EM_PROB_GeneCombiner.numErvilhasGeradas = 0;
	}
}
