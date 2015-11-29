using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public enum DomColor{Red, Yellow, Blue};


public class Eco_Manager : MonoBehaviour {


	private float environmentTotalMass;
	private float environmentYellow;
	private float environmentRed;
	private float environmentBlue;
	public GameObject plankton_prefab;
	public List<Player> AllPlayerList = new List<Player>();
	public List<Plankton> AllPlanktonList = new List<Plankton>();


	void Start () {
		int rand = Random.Range (25, 40);
		for (int i=0; i< rand; i++) {
			GameObject plankto = Instantiate(plankton_prefab, new Vector3(Random.Range (-20, 20), 0, Random.Range (-10, 12)), Quaternion.identity) as GameObject;
		}
	}

	public void CreateAllPlankton(){

	}

	public void SpawnNutrients(){

	}

	public void CheckSuccess(){

	}

	public void AssessEnvironmentalTotals(){

	}

	public void ResetGame(){

	}
}
