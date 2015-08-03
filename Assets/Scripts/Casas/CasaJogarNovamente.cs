using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CasaJogarNovamente: BaseCasa
{
	
	public CasaJogarNovamente(Transform pai, Text textinho, int pos, string frase) : base(pai,textinho,pos){
		mensagem = frase;	
	}
	
	

	
	public override void Executar ()
	{
		quadro.text = mensagem;
	}
}


