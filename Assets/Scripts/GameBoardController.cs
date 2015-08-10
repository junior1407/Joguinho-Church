	using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System;

public class GameBoardController : MonoBehaviour
{
	public AudioClip somMover;
	public GameObject canvasDesativar;
	public GameObject popUpCanvas;
	public GameObject mainCamera;
	public GameObject cameraFim;
	public Animator animator;
	public GameObject luzNice;
	public GameObject main_camera;
	public List<Transform> boardPositions = new List<Transform> ();
	public BaseCasa[] casas = new BaseCasa[65];
	public GameObject[] players;
	public GameObject objectTextoVez;
	public GameObject quadro;
	Text quadroPrincipal;
	public PlayerScript script_atual;
	public float speed = 10f;
	public GameObject player_atual;
	public int ValorDado;
	public int CurrentPosition;
	Transform CasaAlvo;
	GameObject dado;
	GameObject alvo;
	Dado scriptDado;
	public int num_players;
	public Text texto_indicador_vez;


/*	public GameObject pai;
	public GameObject filho;
	BaseCasa teste;*/




	public void addFlagPLayerAtual(){
		GameObject flagzin;
		flagzin = (GameObject) Instantiate(Resources.Load ("Flag"));
		flagzin.transform.SetParent (player_atual.transform,false);
		flagzin.name = "FLAG";

	}
	public void removeFlagPlayerAtual(){
		 Transform z;
		z = player_atual.transform.FindChild ("FLAG");
		Destroy (z.gameObject);
	}
		


	public void AdquirePosicoesTabuleiro ()
	{
		for (int i=1; i<66; i++) {
			Transform datransform = GameObject.Find ("Casa" + i).transform;

			switch (i) {

			case 2:
				casas [i - 1] = (new CasaAvancar (datransform, quadroPrincipal, i, "Pecado! Chame o espírito santo! Avance 3 casas", 3	));
				break;
			
			case 8:
				casas [i - 1] = (new CasaJogarNovamente (datransform, quadroPrincipal, i, "Peça perdao ao irmao e jogue outra vez."));
				break;
			case 14: casas [i - 1] = (new CasaVoltar (datransform, quadroPrincipal, i, "Grite: Meu Deus! Volte uma casa.",1));break;
			case 20: casas [i - 1] = (new CasaVoltar (datransform, quadroPrincipal, i, "Estou com medo. Volte 3 casas.",3));break;
			case 26: casas [i - 1] = (new CasaAvancar (datransform, quadroPrincipal, i, "Sem oração caímos no pecado. Pule 2 casas",2));break;
			case 32:  casas [i - 1] = (new CasaVoltar (datransform, quadroPrincipal, i, "O pecado me deixa sem luz. Volte uma casa",1));break;
			case 38: casas [i - 1] = (new CasaAvancar (datransform, quadroPrincipal, i, "Fujo das tentações. Avance três casas",3));break;
			case 44: casas [i - 1] = (new CasaVoltar (datransform, quadroPrincipal, i, "Não estava vigilante. Volte 3 casas",3));break;
			case 50: casas [i - 1] = (new CasaAvancar (datransform, quadroPrincipal, i, "Socorro jesus! Avance uma casa",1));break; 
			case 56:
				casas [i - 1] = (new CasaVoltar (datransform, quadroPrincipal, i, "O orgulho me faz voltar três casas.",3));
				break;
			 	
			default:
				casas [i - 1] = (new CasaComum (datransform, quadroPrincipal, i));
				break;
			}
		}

			




			




	}

	IEnumerator eventoGG ()
	{

		// codigo que vai acontecer...
		canvasDesativar.SetActive(false);


		mainCamera.SetActive (false);
		cameraFim.SetActive (true);
		animator.SetBool("Ativo", true);
	
		yield return new WaitForSeconds (5);

		Instantiate(luzNice, new Vector3(-4.17f, -0.313f, 41.92f), Quaternion.Euler(-90,0,0));
		popUpCanvas.SetActive(true);
	

	}
	public void chamaOGG(){
		StartCoroutine (eventoGG ());
	}

	public IEnumerator ProximoPlayer ()
	{

		removeFlagPlayerAtual ();

		script_atual = player_atual.GetComponent<PlayerScript> ();
		int ordem_player_atual = script_atual.ordem;

		if (ordem_player_atual < players.Length - 1) {

			player_atual = players [ordem_player_atual + 1];

			
		} else {
			player_atual = players [0];
		}
		Atualizar_Texto ();
		addFlagPLayerAtual ();
		script_atual = player_atual.GetComponent<PlayerScript> ();
		yield return StartCoroutine (CheckarCamera (script_atual));
		/*if ((script_atual.posicao_atual >= ALGO)&(script_atual.posicao_atual <= ALGO)) {
			StartCoroutine(moverdaCamera(new Vector3(-0.16f,12.27f,21.01f)));
		}
		if ((script_atual.posicao_atual >= ALGO)&(script_atual.posicao_atual <= ALGO)) {
			StartCoroutine(moverdaCamera(new Vector3(-0.16f,12.27f,29.47f)));
		}
		if ((script_atual.posicao_atual >= ALGO)&(script_atual.posicao_atual <= ALGO)) {
			StartCoroutine(moverdaCamera(new Vector3(-0.16f,12.27f,37.83f)));
		}*/
		scriptDado.botao_op.interactable = true;
	}
	public IEnumerator CheckarCamera(PlayerScript script_atual){
	
		if (script_atual.posicao_atual <22) {
			yield return StartCoroutine(moverdaCamera(new Vector3(-0.16f,13.5f,4.23f)));
		}
		if ((script_atual.posicao_atual >=22)&(script_atual.posicao_atual <= 33)) {
			yield return StartCoroutine(moverdaCamera(new Vector3(-0.16f,13.5f,12.65f)));
		}
		if ((script_atual.posicao_atual >=34)&(script_atual.posicao_atual <= 46)) {
			yield return StartCoroutine(moverdaCamera(new Vector3(-0.16f,13.5f,21.01f)));
		}
		if ((script_atual.posicao_atual >=47)&(script_atual.posicao_atual <= 58)) {
			yield return StartCoroutine(moverdaCamera(new Vector3(-0.16f,13.5f,29.47f)));
		}
		if ((script_atual.posicao_atual >=59)) {
			yield return StartCoroutine(moverdaCamera(new Vector3(-0.16f,13.5f,37.83f)));
		}
	
	}



	public IEnumerator moverdaCamera(Vector3 nova_pos)	{
		
		float tempo_passado = 0;
		float tempo_total = 1.0f;
		//	player_atual.transform.localPosition = casas[pos_casa].getPositionparaPlayer(ordem_player);
		
		while (tempo_passado<tempo_total) {
			
			main_camera.transform.position = Vector3.Lerp (main_camera.transform.position , nova_pos, tempo_passado / tempo_total);
			tempo_passado += Time.deltaTime;
			yield return 0;
		}
	}

	public void Atualizar_Texto ()
	{
	
		//player_atual = player;

		int vez = player_atual.GetComponent<PlayerScript> ().ordem + 1; 
		texto_indicador_vez.text = "Vez do jogador " + vez;
	
	}

	public void AdquireJogadores () 
	{

		/*
		players= GameObject.FindGameObjectsWithTag ("jogador");

		foreach (GameObject atual in players) {
				
			atual.GetComponent<PlayerScript> ().posicao_atual = 2;
			scriptsplayers.Add (atual.GetComponent<PlayerScript> ());
		}
		num_players = scriptsplayers.Count;
		player_atual = players [0];
		*/

			 GameObject[] temp = GameObject.FindGameObjectsWithTag ("jogador");

		players = new GameObject[temp.Length];

		foreach (GameObject atual in temp) {

			players [atual.GetComponent<PlayerScript> ().ordem] = atual;
			
			atual.GetComponent<PlayerScript> ().posicao_atual = 1;
			//	scriptsplayers.Add (atual.GetComponent<PlayerScript> ());
		}
		//num_players = scriptsplayers.Count;
		player_atual = players [0];
		addFlagPLayerAtual ();
		Atualizar_Texto ();
		script_atual = player_atual.GetComponent<PlayerScript> ();
		num_players = players.Length;	

	}

	public void SpawnaJogadores ()
	{
		num_players = Propriedes.numero_de_jogadores;
			
		Instantiate (Resources.Load ("player/Pecaazul")); 
		if (num_players >= 2) {
			Instantiate (Resources.Load ("player/PecaVermelha"));
			if (num_players >= 3) {
				Instantiate (Resources.Load ("player/PecaVerde"));
				if (num_players >= 4) {
					Instantiate (Resources.Load ("player/PecaAmarela"));
					if (num_players >= 5) {
						Instantiate (Resources.Load ("player/PecaPreta"));
						if (num_players >= 6) {
							Instantiate (Resources.Load ("player/PecaBranca"));
						}
					}
				}
			}
		}
	
					
		
	}

	void Awake ()
	{
		//	quadroPrincipal = GameObject.Find ("textos").GetComponent<Text> ();
		texto_indicador_vez = objectTextoVez.GetComponent<Text> ();
		quadroPrincipal = quadro.GetComponent<Text> ();
		//Debug.Log ("temos "+GameObject.Find("propriedades_jogo").GetComponent<Propriedes>().numero_de_jogadores + " jogadores");
		SpawnaJogadores ();

		AdquireJogadores ();

		AdquirePosicoesTabuleiro ();

		InicializaDado ();


		//teste = new BaseCasa (boardPositions [2], 2); 
/*
		pai = GameObject.Find ("Casa2");
		Transform trans_pai = pai.GetComponent<Transform> ();

		foreach (Transform atual in pai.GetComponent<Transform>()) {
			Debug.Log (atual.gameObject.name);
		}*/
	}

	public void InicializaDado ()
	{
		dado = GameObject.FindGameObjectWithTag ("dado");
		scriptDado = dado.GetComponent<Dado> ();
	
	}

	public int getDadoValor ()
	{

		return scriptDado.currentValue;
	}

	IEnumerator moveIndividual (int pos_casa, int ordem_player)
	{
	
		float tempo_passado = 0.0f;
		float tempo_total = 1.0f;
		//	player_atual.transform.localPosition = casas[pos_casa].getPositionparaPlayer(ordem_player);

		while (tempo_passado<tempo_total) {
		

			player_atual.transform.position = Vector3.Lerp (player_atual.transform.localPosition, casas [pos_casa].getPositionparaPlayer (ordem_player), tempo_passado / tempo_total);
			tempo_passado += Time.deltaTime;
			yield return 0;
		}
		AudioSource.PlayClipAtPoint(somMover, Camera.main.transform.position);
	}

	public IEnumerator mover (int valor_dado)
	{

		Debug.Log(" o valor do dado foi :"+ valor_dado);

		int inicio;
		inicio = script_atual.posicao_atual;


		for (int i=inicio; i< inicio+valor_dado; i++) {

			try{ if(i==65){
					throw new ArgumentOutOfRangeException("OI");
			
				}}
			catch(ArgumentOutOfRangeException e){

			
				Debug.Log(e);
				StopAllCoroutines();
				chamaOGG();
				yield break;
			}

			//	moveIndividual(i,splayer_atual.ordem);
			yield return StartCoroutine (moveIndividual (i, script_atual.ordem));

			//	player_atual.transform.localPosition = casas[i].getPositionparaPlayer(splayer_atual.ordem);
			script_atual.posicao_atual++;
			if (i + 1 == inicio + valor_dado) {
				//Debug.Log ("last move");
				//Debug.Log (casas[i].mensagem);
				casas [i].Executar ();
				yield return new WaitForSeconds(2);
				if (casas [i].GetType () == typeof(CasaJogarNovamente)) {
					scriptDado.botao_op.interactable=true;
					yield break;
				}
				if (casas [i].GetType () == typeof(CasaAvancar)) {
					CasaAvancar ex = (CasaAvancar)casas [i];
					yield return StartCoroutine (mover_semPassar (ex.intensidade));
				}
				if (casas [i].GetType () == typeof(CasaVoltar)) {
					CasaVoltar ex = (CasaVoltar)casas [i];
					yield return StartCoroutine (mover_pratras(ex.intensidade));
				}
			}
		}
			
	
		StartCoroutine (ProximoPlayer ()); 	


	}




	public IEnumerator mover_pratras(int valor_dado){


		PlayerScript splayer_atual = player_atual.GetComponent<PlayerScript> ();

		int inicio;
		inicio = splayer_atual.posicao_atual;
		for (int i=inicio; i> inicio-valor_dado; i--) {

			splayer_atual.posicao_atual --;
			//	moveIndividual(i,splayer_atual.ordem);


		
			yield return StartCoroutine (moveIndividual (i-2, splayer_atual.ordem));
			//	player_atual.transform.localPosition = casas[i].getPositionparaPlayer(splayer_atual.ordem);




		
		}
		

		
	}



	public IEnumerator mover_semPassar (int valor_dado)
	{
		

		PlayerScript splayer_atual = player_atual.GetComponent<PlayerScript> ();
		int inicio;
		inicio = splayer_atual.posicao_atual;
		for (int i=inicio; i< inicio+valor_dado; i++) {
			
			//	moveIndividual(i,splayer_atual.ordem);
			yield return StartCoroutine (moveIndividual (i, splayer_atual.ordem));
			//	player_atual.transform.localPosition = casas[i].getPositionparaPlayer(splayer_atual.ordem);
			splayer_atual.posicao_atual ++;
			if (i + 1 == inicio + valor_dado) {
				//Debug.Log ("last move");
				//Debug.Log (casas[i].mensagem);
				casas [i].Executar ();
				if (casas [i].GetType () == typeof(CasaJogarNovamente)) {
					yield break;
				}
				if (casas [i].GetType () == typeof(CasaAvancar)) {
					CasaAvancar ex = (CasaAvancar)casas [i];
					yield return StartCoroutine (mover (ex.intensidade));
					
					
					
				}
			}
		}
		
		

		
	}


	public float contador=0f;
	void Start ()
	{

		       


	}

	void Update ()
	{
		contador += Time.deltaTime;
	

		if (contador >=240f){
			Application.Quit();
		


	}


	}}


