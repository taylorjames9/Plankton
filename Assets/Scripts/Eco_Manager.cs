using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public enum DomColorState{Red, Yellow, Blue};


public class Eco_Manager : MonoBehaviour {


	private float environmentTotalMass;
	private float environmentYellow;
	private float environmentRed;
	private float environmentBlue;
	public GameObject plankton_prefab;
	public List<Player> AllPlayerList = new List<Player>();
	public List<Plankton> AllPlanktonList = new List<Plankton>();


	void Start () {
		CreateAllPlankton ();
	}

	public void CreateAllPlankton(){
		int rand = Random.Range (25, 40);
		for (int i=0; i< rand; i++) {
			GameObject plankto = Instantiate(plankton_prefab, new Vector3(Random.Range (-50, 50), Random.Range (-20, -40), Random.Range (-30, 30)), Quaternion.identity) as GameObject;
			Plankton plankto_script = plankto.GetComponent<Plankton>();
			plankto_script.Id = i;
			plankto_script.AmtBlue = Random.value;
			plankto_script.AmtRed = Random.value;
			plankto_script.AmtYellow = Random.value;
			plankto_script.AssesDominantColor();
			plankto_script.SetSliders();
			plankto.transform.SetParent(GameObject.FindGameObjectWithTag("Plankton_Holder").transform);

		}
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
