using UnityEngine;
using System.Collections;

public class ControladorParticulas
{

public IEnumerator startarParticulas(){

		Object.Instantiate (Resources.Load ("Brilhozz"));
		yield return 0;
	}
}
