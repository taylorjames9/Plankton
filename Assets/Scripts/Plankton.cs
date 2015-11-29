using UnityEngine;
using System.Collections;





public class Plankton : MonoBehaviour {


	public Sprite myGraphic;
	private float amtYellow;
	public float AmtYellow{ get { return amtYellow; } set { amtYellow = value; } }
	private float amtBlue;
	public float AmtBlue{ get { return amtBlue; } set {amtBlue = value; } }
	private float amtRed;
	public float AmtRed{ get { return  amtRed; } set {amtRed = value; } }
	private int maturitylevel;
	public int Maturitylevel{ get { return  maturitylevel; } set {maturitylevel = value; } }
	private bool isCritical;
	public bool IsCritical{ get { return  isCritical; } set {isCritical = value; } }
	private float timeAlive;
	public float TimeAlive{ get { return timeAlive; } set {timeAlive = value; } }
	private int evolveNum;
	public int EvolveNum { get { return evolveNum; } set {evolveNum = value; } }

	private DomColor myDominantColor;
	public DomColor MyDominantColor{ get { return myDominantColor; } set {myDominantColor = value; } }

	public GameObject maturityIcon;
	public GameObject mySporeHolder;
	public GameObject myBlackInkHolder;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void OnMouseDown(){

	}

	public void Splurt(){

	}

	public void BlackInkSplurt(){

	}

	public void BlackInkRunaway(){

	}

	public void CheckDominantColor(){

	}

	public void SetDominantColor(){

	}

	public void OnTriggerEnter(Collider other){

	}

	public void Evolve(){

	}


}
