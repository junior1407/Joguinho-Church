using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CasaComum: BaseCasa
{

	public CasaComum(Transform pai, Text textinho, int pos) : base(pai,textinho,pos){
		mensagem = randomizaMensagem ();
	
	}


		                 
	#region implemented abstract members of BaseCasa

	public override void Executar ()
	{
		quadro.text = mensagem;
	}

	#endregion

	public string randomizaMensagem(){
		string[] bd_mensagens = new string[]{"Somos amados por Deus, Pai, Filho e Espírito santo.",
			"O amor de Deus é maior.", "Deus é como o sol.",
			"Grande é o vosso nome em toda a terra.",
			"Ó altíssimo, senhor nosso Deus.",
			"Fomos criados à semelhança de Deus.",
			"O amor de Deus constrói tudo.",
			"Em Deus a escuridão acaba.",
			"Eu te chamo pelo nome. És meu.",
			"Salvação em jesus.",
			"O médico jesus cura todos nós.",
			"O sangue de jesus nos lava do pecado.",
			"Com jesus eu consigo.",
			"Deus quer a minha salvação.",
			"Eu quero a minha salvação.",
			"Fé e conversão trazem alegria.",
			"Eu creio em jesus que salva.", 
			"Creio em jesus e vou mudar minha vida.",
			"Tenha fé e siga jesus.",
			"Eu creio e sou batizado. Seguindo pelo caminho de Jesus serei salvo.", 
			"Devo crer, ser batizado e seguir pelo caminho de jesus para ter a salvação.",
			"Devo refletir Jesus aos irmãos.",
			"Amemo-nos uns aos outros.",
			"Jesus gosta da família unida.",
			"Eu e minha casa serviremos ao senhor.",
			"Eu consigo! Com o espírito santo ao meu lado.",
			"Tenha coragem! Deus está com você",
			"Somos templos do espírito santo.",
			"O espírito santo é o que nos orienta.", 
			"O espírito dá a vida.",
			"O espírito santo está comigo."};
		return bd_mensagens[Random.Range(0,bd_mensagens.Length-1)];



		}

	










}

