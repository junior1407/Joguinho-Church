using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CasaAvancar: BaseCasa 

{
	public int intensidade;
	public CasaAvancar(Transform pai, Text textinho, int pos, string frase, int intz) : base(pai,textinho,pos){
		mensagem = frase;	
		intensidade = intz;
	}
	public int getIntensidade(){
		return intensidade;}

	
	
	
	public override void Executar ()
	{
		quadro.text = mensagem;
	}
}


