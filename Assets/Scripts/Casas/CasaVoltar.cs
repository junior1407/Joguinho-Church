using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CasaVoltar: BaseCasa 
	
{
	public int intensidade;
	public CasaVoltar(Transform pai, Text textinho, int pos, string frase, int intz) : base(pai,textinho,pos){
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