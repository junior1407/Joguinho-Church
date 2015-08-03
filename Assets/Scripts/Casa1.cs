using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Casa1{

	public GameObject textoHud;
	//string texto;
	string msgPretaRandom;
	string msgVermelhaRandom;
	string msgVerdeRandom;
	string msgBrancaRandom;
	string msgAmarelaRandom;
	string msgAzulRandom;

	GameObject[] Casas;


	void Awake () 
	{
		textoHud.GetComponent<Text> ();
		Text texto = textoHud.GetComponent<Text>();
		
		string[] MensagensCasasPretas = new string[]{"Pecado! Chame o espírito santo! Avance 3 casas.", "Peça perdão ao irmão e jogue outra vez.", "Grite: Meu Deus! Volte uma casa", "Estou com medo. Volte 3 casas.", "Sem oração caímos no pecado. Pule 2 casas. ", "O pecado me deixa sem luz. Volte uma casa.", "Fujo das tentações. Avance três casas.", "Não estava vigilante. Volte 3 casas.", "Socorro jesus! Avance uma casa.", "Minha esperança vem de Deus. Jogue denovo.", "O orgulho me faz voltar três casas."} ;
		string[] MensagensCasasAmarelas = new string[] {"Somos amados por Deus, Pai, Filho e Espírito santo.", "O amor de Deus é maior.", "Deus é como o sol.", "Grande é o vosso nome em toda a terra.", "Ó altíssimo, senhor nosso Deus.", "Fomos criados à semelhança de Deus.", "O amor de Deus constrói tudo.", "Em Deus a escuridão acaba.", "Eu te chamo pelo nome. És meu."};
		string[] MensagensCasasVermelhas = new string[] {"Salvação em jesus.", "O médico jesus cura todos nós.", "O sangue de jesus nos lava do pecado.", "Grite: Eu serei salvo! e pule 2 casas.", "Com jesus eu consigo.", "Deus quer a minha salvação.", "Eu quero a minha salvação.", };
		string[] MensagensCasasVerdes = new string[] {"Fé e conversão trazem alegria.", "Eu creio em jesus que salva.", "Creio em jesus e vou mudar minha vida.", "Tenha fé e siga jesus.", "Eu creio e sou batizado. Seguindo pelo caminho de Jesus serei salvo.", "Devo crer, ser batizado e seguir pelo caminho de jesus para ter a salvação.", "Devo refletir Jesus aos irmãos."};
		string[] MensagensCasasAzuis = new string[] {"Devo usar de caridade. Abrace o irmão e jogue denovo.", "Amemo-nos uns aos outros.", "A comunidade deve estar em jesus!Avance 3 casas!", "Jesus gosta da família unida.", "Eu e minha casa serviremos ao senhor."};
		string[] MensagensCasasBrancas = new string[] {"Eu consigo! Com o espírito santo ao meu lado.", "Vem, Vem espírito santo! Avance uma casa.", "Tenha coragem! Deus está com você", "Somos templos do espírito santo.", "O espírito santo é o que nos orienta.", "O espírito dá a vida.", "O espírito santo está comigo."};
		
		
		msgPretaRandom = MensagensCasasPretas[Random.Range(0,MensagensCasasPretas.Length)];
		msgAmarelaRandom = MensagensCasasPretas[Random.Range(0,MensagensCasasAmarelas.Length)];
		msgVermelhaRandom = MensagensCasasPretas[Random.Range(0,MensagensCasasVermelhas.Length)];
		msgVerdeRandom = MensagensCasasPretas[Random.Range(0,MensagensCasasVerdes.Length)];
		msgAzulRandom = MensagensCasasPretas[Random.Range(0, MensagensCasasAzuis.Length)];
		msgBrancaRandom = MensagensCasasPretas[Random.Range(0,MensagensCasasBrancas.Length)];
		
		texto.text = msgPretaRandom;
	}

	void aplica()
	{

	}
	
}